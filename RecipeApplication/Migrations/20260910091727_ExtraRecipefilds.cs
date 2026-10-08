using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecipeApplication.Migrations
{
    /// <inheritdoc />
    public partial class ExtraRecipefilds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ISVegan",
                table: "Recipes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsVegetarian",
                table: "Recipes",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ISVegan",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "IsVegetarian",
                table: "Recipes");
        }
    }
}
