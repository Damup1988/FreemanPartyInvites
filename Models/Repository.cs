﻿using System.Collections.Generic;

namespace PartyInvites.Models
{
    public static class Repository
    {
        private static readonly List<GuestResponse> _responses = new List<GuestResponse>();
        public static IEnumerable<GuestResponse> Responses = _responses;

        public static void AddResponse(GuestResponse response)
        {
            _responses.Add(response);
        }
    }
}