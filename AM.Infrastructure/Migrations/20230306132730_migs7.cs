using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class migs7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_Flights_FlightsId",
                table: "FlightPassenger");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_Passengers_PassengersPasseportNumber",
                table: "FlightPassenger");

            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Planes_PlaneFK",
                table: "Flights");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Planes",
                table: "Planes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlightPassenger",
                table: "FlightPassenger");

            migrationBuilder.RenameTable(
                name: "Planes",
                newName: "MyPlanes");

            migrationBuilder.RenameTable(
                name: "FlightPassenger",
                newName: "MyReservation");

            migrationBuilder.RenameColumn(
                name: "Capacity",
                table: "MyPlanes",
                newName: "PlaneCapacity");

            migrationBuilder.RenameIndex(
                name: "IX_FlightPassenger_PassengersPasseportNumber",
                table: "MyReservation",
                newName: "IX_MyReservation_PassengersPasseportNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyPlanes",
                table: "MyPlanes",
                column: "PlaneID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyReservation",
                table: "MyReservation",
                columns: new[] { "FlightsId", "PassengersPasseportNumber" });

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_MyPlanes_PlaneFK",
                table: "Flights",
                column: "PlaneFK",
                principalTable: "MyPlanes",
                principalColumn: "PlaneID");

            migrationBuilder.AddForeignKey(
                name: "FK_MyReservation_Flights_FlightsId",
                table: "MyReservation",
                column: "FlightsId",
                principalTable: "Flights",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MyReservation_Passengers_PassengersPasseportNumber",
                table: "MyReservation",
                column: "PassengersPasseportNumber",
                principalTable: "Passengers",
                principalColumn: "PasseportNumber",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flights_MyPlanes_PlaneFK",
                table: "Flights");

            migrationBuilder.DropForeignKey(
                name: "FK_MyReservation_Flights_FlightsId",
                table: "MyReservation");

            migrationBuilder.DropForeignKey(
                name: "FK_MyReservation_Passengers_PassengersPasseportNumber",
                table: "MyReservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyReservation",
                table: "MyReservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyPlanes",
                table: "MyPlanes");

            migrationBuilder.RenameTable(
                name: "MyReservation",
                newName: "FlightPassenger");

            migrationBuilder.RenameTable(
                name: "MyPlanes",
                newName: "Planes");

            migrationBuilder.RenameIndex(
                name: "IX_MyReservation_PassengersPasseportNumber",
                table: "FlightPassenger",
                newName: "IX_FlightPassenger_PassengersPasseportNumber");

            migrationBuilder.RenameColumn(
                name: "PlaneCapacity",
                table: "Planes",
                newName: "Capacity");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlightPassenger",
                table: "FlightPassenger",
                columns: new[] { "FlightsId", "PassengersPasseportNumber" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Planes",
                table: "Planes",
                column: "PlaneID");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_Flights_FlightsId",
                table: "FlightPassenger",
                column: "FlightsId",
                principalTable: "Flights",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_Passengers_PassengersPasseportNumber",
                table: "FlightPassenger",
                column: "PassengersPasseportNumber",
                principalTable: "Passengers",
                principalColumn: "PasseportNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Planes_PlaneFK",
                table: "Flights",
                column: "PlaneFK",
                principalTable: "Planes",
                principalColumn: "PlaneID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
