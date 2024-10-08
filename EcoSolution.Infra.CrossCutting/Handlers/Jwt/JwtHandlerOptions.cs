﻿namespace EcoSolution.Infra.CrossCutting.Handlers.Jwt
{
    public class JwtHandlerOptions
    {
        public long Id { get; set; }

        public string InscricaoFederal { get; set; }

        public long ClienteId { get; set; }

        public string JwtPrivateKey { get; set; }

        public DateTime ExpireIn { get; set; }
    }
}
