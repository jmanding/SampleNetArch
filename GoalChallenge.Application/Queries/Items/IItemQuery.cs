﻿using GoalChallenge.Domain.Models;

namespace GoalChallenge.Application.Queries
{
    public interface IItemQuery
    {
        List<Item> GetAllItems();
    }
}