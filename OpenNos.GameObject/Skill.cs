﻿/*
 * This file is part of the OpenNos Emulator Project. See AUTHORS file for Copyright information
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 */

using OpenNos.DAL;
using OpenNos.Data;
using System.Collections.Generic;

namespace OpenNos.GameObject
{
    public class Skill : SkillDTO
    {
        #region Instantiation

        public Skill()
        {
            Combos = new List<ComboDTO>();
            Cards = new List<SkillCardDTO>();
        }

        #endregion

        #region Properties

        public List<ComboDTO> Combos { get; set; }
        public List<SkillCardDTO> Cards { get; set; }

        #endregion

        #region Methods

        public override void Initialize()
        {
            // no custom stuff done for Skill
        }

        #endregion
    }
}