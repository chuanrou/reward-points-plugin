﻿using FluentMigrator;
using Nop.Data.Migrations;
using Nop.Plugin.Misc.ExtendedRewardPointsProgram.Domain;

namespace Nop.Plugin.Misc.ExtendedRewardPointsProgram.Data
{
    [SkipMigrationOnUpdate]
    [NopMigration("2021/07/16 09:30:17:6455466", "Misc.ExtendedRewardPointsProgram base schema")]
    public class SchemaMigration : AutoReversingMigration
    {
        protected IMigrationManager _migrationManager;

        public SchemaMigration(IMigrationManager migrationManager)
        {
            _migrationManager = migrationManager;
        }

        public override void Up()
        {
            _migrationManager.BuildTable<RewardPointsOnDateSettings>(Create);
        }
    }
}
