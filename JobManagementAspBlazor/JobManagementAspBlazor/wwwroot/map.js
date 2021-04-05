function navigatorHandle(map, origin, destination, directionsRenderer) {

    // Đường nối hai điểm
    const directionsService = new google.maps.DirectionsService();
    directionsRenderer.setMap(map);
    directionsService.route({
        origin: origin,
        destination: destination,
        travelMode: google.maps.TravelMode.DRIVING,
    },
        (response, status) => {
            // if (status === "OK") {
            directionsRenderer.setDirections(response);
            // } else {
            //     window.alert("Directions request failed due to " + status);
            // }
        });

    const bounds = new google.maps.LatLngBounds();
    const markersArray = [];

    const destinationIcon =
        "https://chart.googleapis.com/chart?" +
        "chst=d_map_pin_letter&chld=D|FF0000|000000";
    const originIcon =
        "https://chart.googleapis.com/chart?" +
        "chst=d_map_pin_letter&chld=O|FFFF00|000000";

    const geocoder = new google.maps.Geocoder();
    const service = new google.maps.DistanceMatrixService();
    service.getDistanceMatrix({
        origins: [origin],
        destinations: [destination],
        travelMode: google.maps.TravelMode.DRIVING,
        unitSystem: google.maps.UnitSystem.METRIC,
        avoidHighways: false,
        avoidTolls: false,
    },
        (response, status) => {
            // if (status !== "OK") {
            //     alert("Error was: " + status);
            // } else {
            const originList = response.originAddresses;
            const destinationList = response.destinationAddresses;
            const outputDiv = document.getElementById("output");
            outputDiv.innerHTML = "";
            deleteMarkers(markersArray);

            const showGeocodedAddressOnMap = function (asDestination) {
                const icon = asDestination ? destinationIcon : originIcon;

                return function (results, status) {
                    if (status === "OK") {
                        map.fitBounds(bounds.extend(results[0].geometry.location));
                        // markersArray.push(
                        //     new google.maps.Marker({
                        //         map,
                        //         position: results[0].geometry.location,
                        //         icon: icon,
                        //     })
                        // );
                    } else {
                        alert("Geocode was not successful due to: " + status);
                    }
                };
            };

            for (let i = 0; i < originList.length; i++) {
                const results = response.rows[i].elements;
                geocoder.geocode({
                    address: originList[i]
                },
                    showGeocodedAddressOnMap(false)
                );

                for (let j = 0; j < results.length; j++) {
                    geocoder.geocode({
                        address: destinationList[j]
                    },
                        showGeocodedAddressOnMap(true)
                    );
                    outputDiv.innerHTML +=
                        originList[i] +
                        " to " +
                        destinationList[j] +
                        ": " +
                        results[j].distance.text +
                        " in " +
                        results[j].duration.text +
                        "<br>";
                }
            }
            // }
        }
    );
}

// let map;

function initMap() {
    let markers = [];
    let map = new google.maps.Map(document.getElementById("map"), {
        center: {
            lat: -34.397,
            lng: 150.644
        },
        zoom: 14,
    });

    let origin = "";
    
    navigator.geolocation.getCurrentPosition((position) => {
        origin = {
            lat: position.coords.latitude,
            lng: position.coords.longitude,
        };
        markers.push(new google.maps.Marker({
            position: origin,
            title: "My position",
            map: map
        }));
        map.setCenter(origin);
    });
    const directionsRenderer = new google.maps.DirectionsRenderer();

    var destinations = document.querySelectorAll(".item-position");
    var items = document.querySelectorAll(".btn-navigator");
    /*window.NavigatorBtnClick = () => {
        
    }*/
    for (var i = 0; i < items.length; i++) {
        let destination = destinations[i].innerHTML;
        items[i].addEventListener("click", () => {
            console.log(destination);
            deleteMarkers(markers);
            navigatorHandle(map, origin, destination, directionsRenderer);
        });
    }
    
}


function deleteMarkers(markersArray) {
    for (let i = 0; i < markersArray.length; i++) {
        markersArray[i].setMap(null);
    }
    markersArray = [];
}

window.Alert = function (message) {
    alert(message);
}
window.Confirm = function (message) {
    return confirm(message);
}
