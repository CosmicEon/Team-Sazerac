﻿using OOPTeamwork.Models.Contracts;

namespace OOPTeamwork.Core.Contracts
{
    public interface ILevelFactory
    {
        ILevel GetLevel(string level);
    }
}