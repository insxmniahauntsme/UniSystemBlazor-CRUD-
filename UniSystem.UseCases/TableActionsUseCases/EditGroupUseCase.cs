﻿using UniSystem.Core.Entities;
using UniSystem.Core.PluginInterfaces;
using UniSystem.UseCases.Interfaces;

namespace UniSystem.UseCases.TableActionsUseCases
{
    public class EditGroupUseCase : IEditGroupUseCase
    {
        private readonly IGroupRepository _groupRepository;

        public EditGroupUseCase(IGroupRepository groupRepository)
        {
            _groupRepository = groupRepository;
        }

        public async Task ExecuteAsync(Group group)
        {
            await _groupRepository.EditGroupAsync(group);
        }
    }
}
