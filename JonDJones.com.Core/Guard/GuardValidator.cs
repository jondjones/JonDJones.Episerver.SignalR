using EPiServer.Core;
using System;

namespace JonDJones.com.Core.Guard
{
    public static class GuardValidator
    {
        public static bool ValidateObject(object objecttoTest)
        {
            if (objecttoTest == null)
            {
                throw new ArgumentException("object passed in has not been instantiated.");
            }

            return true;
        }

        public static bool IsValidContentReference(ContentReference contentReference)
        {
            throw new NotImplementedException();
        }
    }
}
