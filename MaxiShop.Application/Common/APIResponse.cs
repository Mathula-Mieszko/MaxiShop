﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MaxiShop.Application.Common
{
    public class APIResponse
    {
        public HttpStatusCode StatusCode {  get; set; }
        public bool IsSuccess { get; set; } = false;
        public object Result { get; set; }
        public string DisplayMessage { get; set; } = "";

        public List<APIError> Errors { get; set; } = new();
        public List<APIWarning> Warnings { get; set; } = new();

        public void AddError(string errorMessage)
        {
            APIError error = new APIError(errorMessage);
            Errors.Add(error);
        }

        public void AddWarning(string warningMessage) { 
            APIWarning warning = new APIWarning(warningMessage);
            Warnings.Add(warning);
        }
    }
}
