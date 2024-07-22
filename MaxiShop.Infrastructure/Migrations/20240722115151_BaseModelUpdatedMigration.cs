﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaxiShop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class BaseModelUpdatedMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreateOn",
                table: "Categories",
                newName: "CreatedOn");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "Categories",
                newName: "CreateOn");
        }
    }
}
