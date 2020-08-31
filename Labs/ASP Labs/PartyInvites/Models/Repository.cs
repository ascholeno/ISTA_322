using System.Collections.Generic;

namespace PartyInvites.Models
{
    public static class Repository
    {
        private static List<GuestResponse> responses = new List<GuestResponse>(); //Field
        public static IEnumerable<GuestResponse> Responses => responses; //Property
        public static void AddResponse(GuestResponse response)
        {
            responses.Add(response);
        }
    }
}