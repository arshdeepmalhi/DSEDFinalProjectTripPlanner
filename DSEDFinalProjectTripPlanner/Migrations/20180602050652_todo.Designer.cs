﻿// <auto-generated />
using DSEDFinalProjectTripPlanner.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace DSEDFinalProjectTripPlanner.Migrations
{
    [DbContext(typeof(TripContext))]
    [Migration("20180602050652_todo")]
    partial class todo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011");

            modelBuilder.Entity("DSEDFinalProjectTripPlanner.Models.ActivityTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("ConfirmationNumber");

                    b.Property<string>("Country")
                        .IsRequired();

                    b.Property<string>("Description");

                    b.Property<DateTime>("EndDate");

                    b.Property<DateTime>("EndTime");

                    b.Property<int>("NumOfPeopleAttending");

                    b.Property<string>("Postcode");

                    b.Property<string>("Region")
                        .IsRequired();

                    b.Property<DateTime>("StartDate");

                    b.Property<DateTime>("StartTime");

                    b.Property<string>("Suburb");

                    b.Property<string>("SupplierName");

                    b.Property<int>("TripId");

                    b.Property<string>("TypeOfActivity")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("ActivityTasks");
                });

            modelBuilder.Entity("DSEDFinalProjectTripPlanner.Models.CarRental", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConfirmationNumber");

                    b.Property<int>("Door");

                    b.Property<string>("DropoffAddress");

                    b.Property<bool>("DropoffCheckbox");

                    b.Property<string>("DropoffCity");

                    b.Property<string>("DropoffCountry");

                    b.Property<DateTime>("DropoffDate");

                    b.Property<string>("DropoffPostcode");

                    b.Property<string>("DropoffRegion");

                    b.Property<string>("DropoffSuburb");

                    b.Property<DateTime>("DropoffTime");

                    b.Property<int>("LargeBag");

                    b.Property<int>("Litres");

                    b.Property<string>("PickupAddress")
                        .IsRequired();

                    b.Property<string>("PickupCity")
                        .IsRequired();

                    b.Property<string>("PickupCountry")
                        .IsRequired();

                    b.Property<DateTime>("PickupDate");

                    b.Property<string>("PickupName")
                        .IsRequired();

                    b.Property<string>("PickupPostcode");

                    b.Property<string>("PickupRegion")
                        .IsRequired();

                    b.Property<string>("PickupSuburb");

                    b.Property<DateTime>("PickupTime");

                    b.Property<int>("Seats");

                    b.Property<int>("SmallBag");

                    b.Property<string>("SupplierPhoneNumber");

                    b.Property<string>("SuppplierName")
                        .IsRequired();

                    b.Property<string>("Transmission");

                    b.Property<int>("TripId");

                    b.HasKey("Id");

                    b.ToTable("CarRentals");
                });

            modelBuilder.Entity("DSEDFinalProjectTripPlanner.Models.Flight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Airline")
                        .IsRequired();

                    b.Property<DateTime>("ArrivalDate");

                    b.Property<string>("ArrivalGate");

                    b.Property<string>("ArrivalTerminal");

                    b.Property<DateTime>("ArrivalTime");

                    b.Property<string>("ArrivalTo")
                        .IsRequired();

                    b.Property<string>("ConfirmationNumber");

                    b.Property<DateTime>("DepartureDate");

                    b.Property<string>("DepartureFrom")
                        .IsRequired();

                    b.Property<string>("DepartureGate");

                    b.Property<string>("DepartureTerminal");

                    b.Property<DateTime>("DepartureTime");

                    b.Property<string>("FlightNumber")
                        .IsRequired();

                    b.Property<string>("Seats");

                    b.Property<int>("TripId");

                    b.HasKey("Id");

                    b.ToTable("Flights");
                });

            modelBuilder.Entity("DSEDFinalProjectTripPlanner.Models.Human", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ActivityTaskId");

                    b.Property<int>("CarRentalId");

                    b.Property<int>("FlightId");

                    b.Property<string>("FrequentFlyerNumber");

                    b.Property<string>("Fullname");

                    b.Property<int>("LodgingId");

                    b.Property<int>("OtherTransportationId");

                    b.Property<int>("RestaurantId");

                    b.Property<string>("TicketNumber");

                    b.Property<int>("TripId");

                    b.HasKey("Id");

                    b.ToTable("Human");
                });

            modelBuilder.Entity("DSEDFinalProjectTripPlanner.Models.Lodging", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("AddressCity")
                        .IsRequired();

                    b.Property<string>("AddressCountry")
                        .IsRequired();

                    b.Property<string>("AddressPostcode");

                    b.Property<string>("AddressRegion")
                        .IsRequired();

                    b.Property<string>("AddressSuburb")
                        .IsRequired();

                    b.Property<DateTime>("ArrivalDate");

                    b.Property<DateTime>("ArrivalTime");

                    b.Property<string>("ConfirmationNumber");

                    b.Property<DateTime>("DepartureDate");

                    b.Property<DateTime>("DepartureTime");

                    b.Property<string>("LodgingName")
                        .IsRequired();

                    b.Property<int>("NumOfGuests");

                    b.Property<int>("NumOfRooms");

                    b.Property<string>("RoomDescription");

                    b.Property<int>("TripId");

                    b.HasKey("Id");

                    b.ToTable("Lodgings");
                });

            modelBuilder.Entity("DSEDFinalProjectTripPlanner.Models.OtherTransportation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ArrivalAddress")
                        .IsRequired();

                    b.Property<string>("ArrivalCity")
                        .IsRequired();

                    b.Property<string>("ArrivalCountry")
                        .IsRequired();

                    b.Property<DateTime>("ArrivalDate");

                    b.Property<string>("ArrivalPostcode");

                    b.Property<string>("ArrivalRegion")
                        .IsRequired();

                    b.Property<string>("ArrivalSuburb");

                    b.Property<DateTime>("ArrivalTime");

                    b.Property<string>("CarrierName");

                    b.Property<string>("ConfirmationNumber");

                    b.Property<string>("DepartureAddress")
                        .IsRequired();

                    b.Property<string>("DepartureCity")
                        .IsRequired();

                    b.Property<string>("DepartureCountry")
                        .IsRequired();

                    b.Property<DateTime>("DepartureDate");

                    b.Property<string>("DeparturePostcode");

                    b.Property<string>("DepartureRegion")
                        .IsRequired();

                    b.Property<string>("DepartureSuburb");

                    b.Property<DateTime>("DepartureTime");

                    b.Property<int>("TripId");

                    b.Property<string>("TypeOfTransport");

                    b.HasKey("Id");

                    b.ToTable("OtherTransportations");
                });

            modelBuilder.Entity("DSEDFinalProjectTripPlanner.Models.Restaurant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("ConfirmationNumber");

                    b.Property<string>("Country")
                        .IsRequired();

                    b.Property<string>("Cuisine");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description");

                    b.Property<string>("DressCode");

                    b.Property<string>("HoursOfOperation");

                    b.Property<int>("NumberInParty");

                    b.Property<string>("Postcode");

                    b.Property<string>("PriceRange");

                    b.Property<string>("Region")
                        .IsRequired();

                    b.Property<string>("RestaurantName")
                        .IsRequired();

                    b.Property<string>("Suburb");

                    b.Property<DateTime>("Time");

                    b.Property<int>("TripId");

                    b.HasKey("Id");

                    b.ToTable("Restaurants");
                });

            modelBuilder.Entity("DSEDFinalProjectTripPlanner.Models.Trip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("DestinationCity")
                        .IsRequired();

                    b.Property<string>("DestinationCountry")
                        .IsRequired();

                    b.Property<DateTime>("FinishDate");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.ToTable("Trips");
                });
#pragma warning restore 612, 618
        }
    }
}
