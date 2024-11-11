using MVC_Sample.Models;
using NLog;
using System;
using System.Net;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace MVC_Sample.Controllers
{
    public class BaseController : ApiController
    {
        private ILogger _logger;

        public BaseController()
        {
            _logger = LogManager.GetCurrentClassLogger();
        }

        protected void LogInfo(string message)
        {
            _logger.Info(message);
        }

        protected void LogError(string message, Exception ex)
        {
            _logger.Error(ex, message);
        }

        protected JsonResult<DataResult<T>> Ok<T>(T Body, string message = "success")
        {
            var result = new DataResult<T>
            {
                StatusCode = HttpStatusCode.OK,
                Status = HttpStatusCode.OK.ToString(),
                Body = Body,
                Message = message
            };
            return Json(result);
        }

        protected JsonResult<DataResult> Ok(string message)
        {
            var result = new DataResult
            {
                StatusCode = HttpStatusCode.OK,
                Status = HttpStatusCode.OK.ToString(),
                Message = message
            };
            return Json(result);
        }

        protected JsonResult<DataResult<T>> Error<T>(T Body, HttpStatusCode statusCode, string message)
        {
            var result = new DataResult<T>
            {
                StatusCode = statusCode,
                Status = statusCode.ToString(),
                Message = message
            };
            return Json(result);
        }
    }
}
