﻿////<auto-generated <- Codemaid exclusion for now (PacketIndex Order is important for maintenance)
using OpenNos.Core;
using OpenNos.Domain;
using System;
using System.Collections.Generic;

namespace OpenNos.Handler.Packets.ServerPackets
{
    [Header("say")]
    public class SayPacket : PacketBase
    {
        #region Properties

        [PacketIndex(0)]
        public string Message { get; set; }

        #endregion
    }
}