using System;
using System.Collections.Generic;
using System.Text;

namespace MonoBankApi.Models.Requests
{
    public abstract class MonoRequest
    {
        public abstract string Url();
    }
}
