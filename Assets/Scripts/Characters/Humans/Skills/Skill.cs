﻿using System.Collections.Generic;

namespace Assets.Scripts.Characters.Humans.Skills
{
    public abstract class Skill
    {
        protected readonly Hero Hero;

        protected Skill(Hero hero)
        {
            Hero = hero;
        }

        public List<EquipmentType> CompatibleEquipmentTypes = new List<EquipmentType>();

        public float Cooldown { get; set; }

        public bool IsActive { get; set; }
        public abstract void Use();
        public abstract void OnUpdate();

        // Skills seem to check on Hero State:
        // Grabbed: Jean & Eren
        // Idle: Eren, Marco, Armin, Sasha, Mikasa, Levi, Petra

        // Special skill: bomb, which is used for bomb pvp.

        // Some skills check whether or not the player is on the ground
        // None of the skills currently are working for AHSS
        // AHSS skill would be dual shot
    }
}
