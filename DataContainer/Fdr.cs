using System;
using System.Dynamic;
using System.Web.UI.WebControls;
using OrakYazilimLib.Util;
using System.Data;

namespace OrakYazilimLib.DataContainer
{
    public class Fdr<T>
    {
        private bool? _boResult;

        public bool? boResult
        {
            get
            {
                return _boResult;
            }

            set
            {
                _boResult = value;
                blResult = value;
            }
        }

        /// <summary>
        /// deprecated - boResult kullan
        /// </summary>
        public bool? blResult { get; set; }
        public T obReturn { get; set; }
        public T refValue { get; set; }
        public string txErrorMsgShort { get; set; }
        public string txErrorMsgDetail { get; set; }
        public int lnRowsAffected { get; set; }
        public int? lnIdAffected { get; set; }
        public int? lnTotalLength { get; set; }
        public object spec1 { get; set; }

        public int? lnStatusCode { get; set; }

        public string txId {get;set;}

        public string txMessage {get;set;}

        public Exception refException {get;set;}

        /**
         * External Object
         */
        public void SetExtObject<TS>(TS value)
        {
            this.spec1 = value;
        }

        public TS GetExtObject<TS>()
        {
            return (TS)this.spec1;
        }

        public Fdr(bool prmBlResult) { this.blResult = prmBlResult; }

        public Fdr(int prmLnRowsAffected)
        {
            this.lnRowsAffected = prmLnRowsAffected;

            if (prmLnRowsAffected > 0)
            {
                this.blResult = true;
            }
            else
            {
                this.blResult = false;
            }

        }

        public Fdr() { }

        public static Fdr<T> FactoryScopeId(int prmIdAffected)
        {
            var fiReturn = new Fdr<T>();
            fiReturn.lnIdAffected = prmIdAffected;
            fiReturn.lnRowsAffected = prmIdAffected;

            if (prmIdAffected > 0)
            {
                fiReturn.blResult = true;
            }
            else
            {
                fiReturn.blResult = false;
            }

            return fiReturn;
        }

        public static Fdr<T> FactoryObject(T returnObject)
        {
            var fiReturn = new Fdr<T>();
            fiReturn.obReturn = returnObject;
            return fiReturn;
        }

        public void ExceptionQueryErrorLog(Exception exception)
        {
            this.txErrorMsgShort = exception.Message;
            this.txErrorMsgDetail = FiLogWeb.getStackTrace(exception);
            this.lnRowsAffected = -1;
            this.blResult = false;
            this.boResult = false;
        }

        public bool isTrueResult()
        {
            if(this.blResult == null) return false;
            return blResult.Value;
        }

        public bool isTrueBoResult()
        {
            if (this.blResult == null) return false;
            return blResult.Value;
        }

        public Fdr<T> buiMess(string txMessage)
        {
            this.txMessage = txMessage;
            return this;
        }
    }

    public class Fdr : Fdr<object>
    {
        public Fdr()
        {

        }

        public Fdr(bool v)
        {
            base.blResult = v;
            base.boResult = v;
        }
    }
}