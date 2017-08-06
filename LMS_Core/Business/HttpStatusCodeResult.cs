using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LMS_Core.Business
{
    class HttpStatusCodeResult
    {
        private System.Net.HttpStatusCode httpStatusCode;

        public HttpStatusCodeResult(System.Net.HttpStatusCode httpStatusCode)
        {
            // TODO: Complete member initialization
            this.httpStatusCode = httpStatusCode;
        }
    }
}
