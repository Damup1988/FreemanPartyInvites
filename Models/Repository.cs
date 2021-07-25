using System.Collections.Generic;

namespace PartyInvites.Models
{
    public class Repository
    {
        private static List<GuestResponse> _responses = new List<GuestResponse>();
        public static IEnumerable<GuestResponse> Responses = _responses;

        public static void AddResponce(GuestResponse response)
        {
            _responses.Add(response);
        }
    }
}