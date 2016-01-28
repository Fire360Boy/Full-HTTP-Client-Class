using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Httpful
{
    /// <summary>
    /// Author : Fire360Boy
    /// Author Email : Fire360Boy@gmail.com
    /// </summary>
    class Http
    {
        public const string HEAD    = "HEAD";
        public const string GET     = "GET";
        public const string POST    = "POST";
        public const string PUT     = "PUT";
        public const string DELETE  = "DELETE";
        public const string PATCH   = "PATCH";
        public const string OPTIONS = "OPTIONS";
        public const string TRACE   = "TRACE";

        /// <summary>
        /// 
        /// </summary>
        /// <returns>list of HTTP method strings</returns>
        public static List<string> safeMethods()
        {
            return new List<string>
            {
                Http.HEAD,      Http.GET,
                Http.OPTIONS,   Http.TRACE,
            };
        }



        /// <summary>
        /// check method to exist on safe methods
        /// GET , HEAD , OPTIONS , TRACE Methods is safe
        /// </summary>
        /// <param name="method">string of HTTP method</param>
        /// <returns>return true if exist method on safeMethods</returns>
        public static bool isSafeMethod(string method)
        {
            return Http.safeMethods().Contains(method);
        }


        /// <summary>
        /// check method to exist on UnSafe methods
        /// POST , PUT , DELETE , PATCH , ... Methods is UnSafe
        /// </summary>
        /// <param name="method">string of method name</param>
        /// <returns></returns>
        public static bool isUnsafeMethod(string method)
        {

            return !Http.safeMethods().Contains(method);
        }


        public static List<string> idempotentMethods()
        {
            return new List<string>
            {
                Http.HEAD,      Http.GET,
                Http.PUT,       Http.DELETE,
                Http.OPTIONS,   Http.TRACE,
                Http.PATCH
            };
        }


        public static bool isIdempotent(string meyhod)
        {
            return Http.idempotentMethods().Contains(meyhod);
        }

        public static bool isNotIdempotent(string method)
        {
            return !Http.idempotentMethods().Contains(method);
        }

        public static List<string> canHaveBody()
        {
            return new List<string>
            {
                Http.POST,      Http.PUT,
                Http.PATCH,     Http.OPTIONS
            };
        }

    }
}
