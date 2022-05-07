﻿using GoalChallenge.Common.Models;
using GoalChallenge.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalChallenge.Application.Commands.Items
{
    public class AddItemsToInvetoryCommand : IRequest
    {
        public InventoryInput Inventory { get; set; }

        public AddItemsToInvetoryCommand(InventoryInput inventory)
        {
            Inventory = inventory;
        }
    }
}
