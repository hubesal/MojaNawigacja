var directionsDisplay;
var directionsService;
var map;

function wyswietlMape(mapDivId)
{
    var torun = new google.maps.LatLng(53.0137902, 18.5984437);
    var opcje =
    {
        zoom: 11,
        mapTypeId: google.maps.MapTypeId.ROADMAP,
        center: torun
    }

    directionsService = new google.maps.DirectionsService();

    directionsDisplay = new google.maps.DirectionsRenderer();
    map = new google.maps.Map(document.getElementById(mapDivId), opcje);
    directionsDisplay.setMap(map);
}

function wyznaczTrase(startTextId, endTextId)
{
    var start = document.getElementById(startTextId).value;
    var end = document.getElementById(endTextId).value;

    if (start != "" && end != "")
    {
        var request =
        {
            origin: start,
            destination: end,
            travelMode: google.maps.DirectionsTravelMode.DRIVING
        };

        directionsService.route(request, function (response, status) {
            if (status == google.maps.DirectionsStatus.OK) {
                directionsDisplay.setDirections(response);
            }
        });
    }
}