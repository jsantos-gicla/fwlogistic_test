using fwlogistic_test.FWLServiceReference;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace fwlogistic_test
{
    public class Program
    {
        private static FLCallbackHandler _callbacks;
        private static InstanceContext context;
        private static fwlsServiceClient _client;
        private static fwlsSession _session = null;

        static void Main(string[] args)
        {
            Console.WriteLine("Inicio");

            try
            {
                string err_msg = null;
                _callbacks = new FLCallbackHandler();
                context = new InstanceContext(_callbacks);
                _client = new fwlsServiceClient(context);

                Console.WriteLine("Ejecutando: SessionCreate");
                var _session = _client.SessionCreate(out err_msg, "WIS", "wis", "wis");

                if (string.IsNullOrEmpty(err_msg) && _session != null)
                {
                    Console.WriteLine("SessionCreate: OK");

                    int value = _client.ServerAlive();

                    Coords coords = new Coords
                    {
                        x = -3.695736,
                        y = 40.426104
                    };

                    List<Coords> coordsList = new List<Coords>
                    {
                                coords
                    };

                    LocateData locateData = new LocateData
                    {
                        coords = coordsList,
                        maxHierarchy = 0,
                        maxSnapTolerance = 2500
                    };

                    Console.WriteLine("Ejecutando LocateOverNetworkAsync");
                    _client.LocateOverNetworkAsync(_session, new Guid(), locateData, null);
                }
                else
                {
                    Console.WriteLine("SessionCreate ERROR: " + err_msg);
                }

                Console.WriteLine("Service Wait");
            }
            catch (Exception ex)
            {
                Console.WriteLine("EXCEPTION");
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (_session != null && _client != null)
                {
                    string errmsg = null;
                    _client.SessionClose(out errmsg, _session);
                    if (!string.IsNullOrEmpty(errmsg))
                    {
                        Console.WriteLine("ERROR SessionClose: " + errmsg);
                    }
                }
            }

            Console.WriteLine("Presione una tecla para terminar");
            string input_fin = Console.ReadLine();
        }
    }
}