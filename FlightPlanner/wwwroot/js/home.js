'use strict';
$(document).ready(function () {
    $("#alertSuccess").hide();
    $('#alertDanger').hide();
    GetAirports();
    GetFlights();
})

function BookFlight() {

    $('#destinationId').val($('#arrivalAirport').val());
    $('#locationId').val($('#departureAirport').val());

    var flightObj = {
        DestinationId: $('#destinationId').val(),
        LocationId: $('#locationId').val(),
        NumberOfPassengers: $('#passengerNumber').val(),
        StartDate: $('#startDate').val(),
        EndDate: $('#endDate').val(),
        Id: $('#hiddenUserId').val()
    }

    console.log(flightObj);
    if (ValidateData() != false) {
        $.ajax({
            url: "/Home/BookFlight",
            type: "POST",
            contentType: "application/json",
            data: JSON.stringify(flightObj),
            success: function (response) {
                console.log(response);
                if (response == 'success') {
                    GetFlights();
                    $('#alertSuccess').show()
                    $('#alertSuccess').text("Flight successfully booked!")
                } else {
                    GetFlights();
                    $('#alertDanger').show()
                    $('#alertDanger').text("Some error occured, try again!")
                }
            },
            error: function (errorMessage) {
                $('#alertDanger').show()
                $('#alertDanger').text("errorMessage.responseText")
            }
        })
    }
}

function GetAirports() {
    $.ajax({
        url: "/Home/GetAirports",
        type: "GET",
        contentType: "application/json",
        dataType: "json",
        success: function (response) {
            console.log(response);
            var dropdown = $('.airportDropdown');
            var dropdownDeparture = $('.dropdownDeparture')
            var dropdownArrival = $('.dropdownArrival')
            dropdown.empty();
            $.each(response, function (index, item) {
                dropdown.append($('<option></option>').attr('value', item.value).text(item.text));
            });
            dropdownDeparture.append($('<option value="" disabled selected> Departure Airport </option>'));
            dropdownArrival.append($('<option value="" disabled selected> Arrival Airport </option>'));
        },
        error: function (error) {
            alert('Error fetching airports: ' + error);
        }
    })
}

function GetFlights() {
    $.ajax({
        url: "/Home/GetFlights",
        type: "GET",
        contentType: "application/json",
        dataType: "json",
        success: function (response) {
            console.log(response);
            var html = '';
            $.each(response, function (key, item) {
                console.log(response);
                html += '<tr>';
                html += '<td>' + item.departure + '</td>';
                html += '<td>' + item.arrival + '</td>';
                html += '<td>' + item.departureDate + '</td>';
                html += '<td>' + item.arrivalDate + '</td>';
                html += '</tr>';
            });
            $('.tbody').html(html);
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    })
}

function ValidateData() {
    var flightObj = {
        DestinationId: $('#destinationId').val(),
        LocationId: $('#locationId').val(),
        NumberOfPassengers: $('#passengerNumber').val(),
        StartDate: $('#startDate').val(),
        EndDate: $('#endDate').val(),
        Id: $('#hiddenUserId').val()
    }
    console.log(flightObj);
    console.log('inside validatedata');
    if (flightObj.DestinationId == "" | flightObj.LocationId == "") {
        $('#alertDanger').show();
        $('#alertDanger').text("Please select a valid departure, and arrival location");
        return false;
    } else if (flightObj.DestinationId == flightObj.LocationId) {
        $('#alertDanger').show()
        $('#alertDanger').text("Please select two different departure, and arrival locations")
        return false;
    } else if (flightObj.StartDate == "" | flightObj.EndDate == "") {
        $('#alertDanger').show()
        $('#alertDanger').text("Please ensure that you have set valid dates")
        return false;
    } else if (flightObj.StartDate > flightObj.EndDate) {
        $('#alertDanger').show()
        $('#alertDanger').text("Please select a departure date that occurs before your arrival")
        return false;
    } else if (flightObj.NumberOfPassengers > 25) {
        flightObj.NumberOfPassengers = 25;
        return false;
    } else if (flightObj.NumberOfPassengers < 1) {
        flightObj.NumberOfPassengers = 1;
        return false;
    } else {
        return true;
    }
}

