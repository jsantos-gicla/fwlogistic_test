using fwlogistic_test.FWLServiceReference;
using System;

namespace fwlogistic_test
{
    class FLCallbackHandler : fwlsServiceCallback
    {
        public IAsyncResult BeginErrorInProblem(ProblemAbstract p, string errorMessage, AsyncCallback callback, object asyncState)
        {
            throw new NotImplementedException();
        }

        public IAsyncResult BeginProblemCanceled(ProblemAbstract p, AsyncCallback callback, object asyncState)
        {
            throw new NotImplementedException();
        }

        public IAsyncResult BeginProblemEvaluated(ProblemAbstract p, AsyncCallback callback, object asyncState)
        {
            throw new NotImplementedException();
        }

        public IAsyncResult BeginProblemSolved(ProblemAbstract p, AsyncCallback callback, object asyncState)
        {
            throw new NotImplementedException();
        }

        public IAsyncResult BeginServerPing(DateTime timestamp, AsyncCallback callback, object asyncState)
        {
            throw new NotImplementedException();
        }

        public void EndErrorInProblem(IAsyncResult result)
        {
            throw new NotImplementedException();
        }

        public void EndProblemCanceled(IAsyncResult result)
        {
            throw new NotImplementedException();
        }

        public void EndProblemEvaluated(IAsyncResult result)
        {
            throw new NotImplementedException();
        }

        public void EndProblemSolved(IAsyncResult result)
        {
            throw new NotImplementedException();
        }

        public void EndServerPing(IAsyncResult result)
        {
            throw new NotImplementedException();
        }

        public void ErrorInProblem(ProblemAbstract p, string errorMessage)
        {
            throw new NotImplementedException();
        }

        public void ProblemCanceled(ProblemAbstract p)
        {
            throw new NotImplementedException();
        }

        public void ProblemEvaluated(ProblemAbstract p)
        {
            throw new NotImplementedException();
        }

        public void ProblemSolved(ProblemAbstract p)
        {
            throw new NotImplementedException();
        }

        public void ServerPing(DateTime timestamp)
        {
            throw new NotImplementedException();
        }
    }
}
