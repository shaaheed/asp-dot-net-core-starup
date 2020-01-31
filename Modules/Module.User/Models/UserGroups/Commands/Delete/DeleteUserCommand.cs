﻿using Core.Infrastructure.Commands;
using Core.Infrastructure.Responses;

namespace Application.UserGroups.Commands
{
    public class DeleteUserGroupCommand : ICommand<CommandResponse<long>>
    {
        public long Id { get; set; }

    }

}
