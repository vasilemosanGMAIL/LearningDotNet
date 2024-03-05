using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeptions
{
    public class Exercise30
    {

    }

    public class InvalidTransactionException : Exception
    {
        public TransactionData TransactionData { get; }
        public InvalidTransactionException()
        {
            
        }

        public InvalidTransactionException(string message) : base(message)
        {
            
        }

        public InvalidTransactionException(string message, Exception innerException) : base(message, innerException)
        {
            
        }

        public InvalidTransactionException(string message, TransactionData data) : base(message)
        {
            TransactionData = data;
        }

        public InvalidTransactionException(string message, TransactionData data, Exception innerException) : base(message, innerException)
        {
            TransactionData = data;
        }
    }

    public class TransactionData
    {
        public string Sender { get; init; }
        public string Receiver { get; init; }
        public decimal Amount { get; init; }
    }
}
