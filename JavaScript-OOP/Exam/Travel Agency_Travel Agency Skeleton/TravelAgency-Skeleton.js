function processTravelAgencyCommands(commands) {
    'use strict';

    Object.prototype.extends = function(parent) {
        this.prototype = Object.create(parent.prototype);
        this.prototype.constructor = this;
    }

    String.prototype.isEmpty = function(){
        return this ? false : true;
    }

    Array.prototype.remove = function(from, to) {
        if(!this.length){
            throw new Error('Empty destinations');
        }
        var rest = this.slice((to || from) + 1 || this.length);
        this.length = from < 0 ? this.length + from : from;
        return this.push.apply(this, rest);
    };

    Array.prototype.insert = function (index, item) {
        this.splice(index, 0, item);
    };

    var Models = (function() {
        var Destination = (function() {
            function Destination(location, landmark) {
                this.setLocation(location);
                this.setLandmark(landmark);
            }

            Destination.prototype.getLocation = function() {
                return this._location;
            }

            Destination.prototype.setLocation = function(location) {
                if (location === undefined || location === "") {
                    throw new Error("Location cannot be empty or undefined.");
                }
                this._location = location;
            }

            Destination.prototype.getLandmark = function() {
                return this._landmark;
            }

            Destination.prototype.setLandmark = function(landmark) {
                if (landmark === undefined || landmark == "") {
                    throw new Error("Landmark cannot be empty or undefined.");
                }
                this._landmark = landmark;
            }

            Destination.prototype.toString = function() {
                return this.constructor.name + ": " +
                    "location=" + this.getLocation() +
                    ",landmark=" + this.getLandmark();
            }

            return Destination;
        }());

        var Travel = (function() {
            function Travel(name, startDate, endDate, price){
                if (this.constructor === Travel) {
                    throw new Error('Cannot instantiate abstract class Travel.');
                }
                this.setName(name);
                this.setStartDate(startDate);
                this.setEndDate(endDate);
                this.setPrice(price);
            }

            Travel.prototype.setName = function(name){
                if(!name){
                    throw new Error('Name can not be undefined!');
                }
                if(name.isEmpty()){
                    throw new Error('Name can not be empty!');
                }
                this._name = name;
            }

            Travel.prototype.getName = function(){
                return this._name;
            }

            Travel.prototype.setStartDate = function(startDate){
                this._startDate = startDate;
            }

            Travel.prototype.getStartDate = function(){
                return this._startDate;
            }

            Travel.prototype.setEndDate = function(endDate){
                this._endDate = endDate;
            }

            Travel.prototype.getEndDate = function(){
                return this._endDate;
            }

            Travel.prototype.setPrice = function(price){
                if(!price){
                    throw new Error('Price can not be undefined!');
                }
                if (price < 0) {
                    throw new Error('Price must be non-negative number');
                }
                this._price = price;
            }

            Travel.prototype.getPrice = function(){
                return this._price;
            }

            function formatDate(dateString){
                var m_names = new Array("Jan", "Feb", "Mar", 
                "Apr", "May", "Jun", "Jul", "Aug", "Sep", 
                "Oct", "Nov", "Dec");

                var curr_date = dateString.getDate();
                var curr_month = dateString.getMonth();
                var curr_year = dateString.getFullYear();
                var formated = curr_date + "-" + m_names[curr_month] 
                + "-" + curr_year;

                return formated;
            }

            Travel.prototype.toString = function(){
                return ' * ' + this.constructor.name + 
                        ': name=' + this.getName() +
                        ',start-date=' + formatDate(this.getStartDate()) +
                        ',end-date=' + formatDate(this.getEndDate()) +
                        ',price=' + this.getPrice().toFixed(2);
            }

            return Travel;
        }());

        var Excursion = (function(){
            function Excursion(name, startDate, endDate, price, transport){
                Travel.apply(this, arguments);
                this.setTransport(transport);
                this._destinations = [];
            }

            Excursion.extends(Travel);

            Excursion.prototype._type = 'Excursion';

            Excursion.prototype.setTransport = function(transport){
                if(!transport){
                    throw new Error('Transport can not be undefined!');
                }
                if(transport.isEmpty()){
                    throw new Error('Transport must not be empty!');
                }
                this._transport = transport;
            }

            Excursion.prototype.getTransport = function(){
                return this._transport;
            }

            Excursion.prototype.addDestination = function(destination){
                this._destinations.push(destination);
            }

            Excursion.prototype.getDestinations = function(){
                return this._destinations;
            }

            Excursion.prototype.removeDestination = function(destination){
                var index = this.getDestinations().indexOf(destination);
                if(index < 0){
                    throw new Error('No such destination');
                }
                this.getDestinations().remove(index);
            }

            Excursion.prototype.toString = function(){
                var destinationString = "Destinations: ";
                var destinations = this.getDestinations();
                var length = destinations.length;                
                var i = 1;
                destinations.forEach(function(dest){
                    destinationString += dest.toString();
                    if(i < length){
                        destinationString +=';';
                    }
                    i++;
                });
                if(length == 0){
                    destinationString += "-";
                }
                return Travel.prototype.toString.call(this) +
                        ',transport=' + this.getTransport() +
                        "\n ** "+ destinationString;
            }
            return Excursion;
        }());

        var Vacation = (function(){
            function Vacation(name, startDate, endDate, price, location, accommodation){
                Travel.apply(this, arguments);
                this.setLocation(location);
                this.setAccommodation(accommodation);
            }

            Vacation.extends(Travel);

            Vacation.prototype._type = 'Vacation';

            Vacation.prototype.setLocation = function(location){
                if(!location){
                    throw new Error('Location can not be undefined!');
                }
                if(location.isEmpty()){
                    throw new Error('Location must not be empty!');
                }
                this.location = location;
            }

            Vacation.prototype.getLocation = function(){
                return this.location;
            }

            Vacation.prototype.setAccommodation = function(accommodation){
                if(accommodation != undefined){
                    if(accommodation.isEmpty()){
                        throw new Error('Accommodation must not be empty!');
                    }
                    this.accommodation = accommodation;
                }
            }

            Vacation.prototype.getAccommodation = function(){
                return this.accommodation;
            }

            Vacation.prototype.toString = function(){
                var accommodation = "";
                if(this.getAccommodation()){
                    accommodation = ',accommodation='+this.getAccommodation();
                }

                return Travel.prototype.toString.call(this) + 
                        ',location=' + this.getLocation() +
                        accommodation;
            }

            return Vacation;
        }());

        var Cruise = (function(){
            function Cruise(name, startDate, endDate, price, startDock) {
                var args = [];
                for(var i = 0; i < 4; i++){
                    args[i] = arguments[i];
                }
                args[4] = 'cruise liner';
                Excursion.apply(this, args);
                this.setStartDock(startDock);
            }

            Cruise.extends(Excursion);

            Cruise.prototype._type = 'Cruise';

            Cruise.prototype.setStartDock = function(dock){
                if(dock){
                    if(dock.isEmpty()){
                        throw new Error('Dock must not be empty!');
                    }

                    this._startDock = dock;
                }
            }

            Cruise.prototype.getStartDock = function () {
                return this._startDock;
            }

            return Cruise;
        }());

        return {
            Destination: Destination,
            Vacation: Vacation,
            Excursion: Excursion,
            Cruise: Cruise
        }
    }());

    var TravellingManager = (function(){
        var _travels;
        var _destinations;

        function init() {
            _travels = [];
            _destinations = [];
        }

        var CommandProcessor = (function() {

            function processInsertCommand(command) {
                var object;

                switch (command["type"]) {
                    case "excursion":
                        object = new Models.Excursion(command["name"], parseDate(command["start-date"]), parseDate(command["end-date"]),
                            parseFloat(command["price"]), command["transport"]);
                        _travels.push(object);
                        break;
                    case "vacation":
                        object = new Models.Vacation(command["name"], parseDate(command["start-date"]), parseDate(command["end-date"]),
                            parseFloat(command["price"]), command["location"], command["accommodation"]);                        
                        _travels.push(object);
                        break;
                    case "cruise":
                        object = new Models.Cruise(command["name"], parseDate(command["start-date"]), parseDate(command["end-date"]),
                            parseFloat(command["price"]), command["start-dock"]);
                        _travels.push(object);
                        break;
                    case "destination":
                        object = new Models.Destination(command["location"], command["landmark"]);
                        _destinations.push(object);
                        break;
                    default:
                        throw new Error("Invalid type.");
                }

                return object.constructor.name + " created.";
            }

            function processDeleteCommand(command) {
                var object,
                    index,
                    destinations;

                switch (command["type"]) {
                    case "destination":
                        object = getDestinationByLocationAndLandmark(command["location"], command["landmark"]);
                        _travels.forEach(function(t) {
                            if (t instanceof Models.Excursion && t.getDestinations().indexOf(object) !== -1) {
                                t.removeDestination(object);
                            }
                        });
                        index = _destinations.indexOf(object);
                        _destinations.splice(index, 1);
                        break;
                    case "excursion":
                    case "vacation":
                    case "cruise":
                        object = getTravelByName(command["name"]);
                        index = _travels.indexOf(object);
                        _travels.splice(index, 1);
                        break;
                    default:
                        throw new Error("Unknown type.");
                }

                return object.constructor.name + " deleted.";
            }

            function processListCommand(command) {
                return formatTravelsQuery(_travels);
            }

            function processAddDestinationCommand(command) {
                var destination = getDestinationByLocationAndLandmark(command["location"], command["landmark"]),
                    travel = getTravelByName(command["name"]);

                if (!(travel instanceof Models.Excursion)) {
                    throw new Error("Travel does not have destinations.");
                }
                travel.addDestination(destination);

                return "Added destination to " + travel.getName() + ".";
            }

            function processRemoveDestinationCommand(command) {
                var destination = getDestinationByLocationAndLandmark(command["location"], command["landmark"]),
                    travel = getTravelByName(command["name"]);

                if (!(travel instanceof Models.Excursion)) {
                    throw new Error("Travel does not have destinations.");
                }
                travel.removeDestination(destination);

                return "Removed destination from " + travel.getName() + ".";
            }

            function getTravelByName(name) {
                var i;

                for (i = 0; i < _travels.length; i++) {
                    if (_travels[i].getName() === name) {
                        return _travels[i];
                    }
                }
                throw new Error("No travel with such name exists.");
            }

            function getDestinationByLocationAndLandmark(location, landmark) {
                var i;

                for (i = 0; i < _destinations.length; i++) {
                    if (_destinations[i].getLocation() === location
                        && _destinations[i].getLandmark() === landmark) {
                        return _destinations[i];
                    }
                }
                throw new Error("No destination with such location and landmark exists.");
            }

            function formatTravelsQuery(travelsQuery) {
                var queryString = "";
                if (travelsQuery.length > 0) {
                    queryString += travelsQuery.join("\n");
                } else {
                    queryString = "No results.";
                }

                return queryString;
            }

            function processFilterTravelsCommand(filterArgs){
                var results = [];
                _travels.forEach(function(travel){
                    if(filterArgs['type'] != 'all'){
                        if(travel.constructor.name.toLowerCase() == filterArgs['type']){
                            if(isMatchingTravel(travel, filterArgs)){
                                results.push(travel);
                            }
                        }
                    }
                    else{
                        if(isMatchingTravel(travel, filterArgs)){
                            results.push(travel);
                        }
                    }
                });
                //console.log(results);
                return results.sort(function(a, b){
                    var aDate = a.getStartDate();
                    var bDate = b.getStartDate();
                    console.log(aDate.toUTCString());
                    console.log(bDate.toUTCString());
                    // if(aDate.getUTCFullYear() == bDate.getUTCFullYear() && 
                    //     aDate.getUTCMonth() == bDate.getUTCMonth() && 
                    //     aDate.getUTCDate() == bDate.getUTCDate()){
                    // if(aDate == bDate){
                    if(aDate.toUTCString() == bDate.toUTCString()){
                        return a.getName().localeCompare(b.getName());
                    }
                    else{
                        return aDate > bDate ? 1 : -1;
                    }
                }).join('\n');
            }

            function isMatchingTravel(travel, filter){
                if(travel.getPrice() >= filter['price-min'] && travel.getPrice() <= filter['price-max']){
                    return true;
                }
                return false;
            }

            return {
                processInsertCommand: processInsertCommand,
                processDeleteCommand: processDeleteCommand,
                processListCommand: processListCommand,
                processAddDestinationCommand: processAddDestinationCommand,
                processRemoveDestinationCommand: processRemoveDestinationCommand,
                processFilterTravelsCommand: processFilterTravelsCommand
            }
        }());

        var Command = (function() {
            function Command(cmdLine) {
                this._cmdArgs = processCommand(cmdLine);
            }

            function processCommand(cmdLine) {
                var parameters = [],
                    matches = [],
                    pattern = /(.+?)=(.+?)[;)]/g,
                    key,
                    value,
                    split;

                split = cmdLine.split("(");
                parameters["command"] = split[0];
                while ((matches = pattern.exec(split[1])) !== null) {
                    key = matches[1];
                    value = matches[2];
                    parameters[key] = value;
                }

                return parameters;
            }

            return Command;
        }());

        function executeCommands(cmds) {
            var commandArgs = new Command(cmds)._cmdArgs,
                action = commandArgs["command"],
                output;

            switch (action) {
                case "insert":
                    output = CommandProcessor.processInsertCommand(commandArgs);
                    break;
                case "delete":
                    output = CommandProcessor.processDeleteCommand(commandArgs);
                    break;
                case "add-destination":
                    output = CommandProcessor.processAddDestinationCommand(commandArgs);
                    break;
                case "remove-destination":
                    output = CommandProcessor.processRemoveDestinationCommand(commandArgs);
                    break;
                case "list":
                    output = CommandProcessor.processListCommand(commandArgs);
                    break;
                case "filter":
                    output = CommandProcessor.processFilterTravelsCommand(commandArgs);
                    break;
                default:
                    throw new Error("Unsupported command.");
            }

            return output;
        }

        return {
            init: init,
            executeCommands: executeCommands
        }
    }());

    var parseDate = function (dateStr) {
        if (!dateStr) {
            return undefined;
        }
        var date = new Date(Date.parse(dateStr.replace(/-/g, ' ')));
        var dateFormatted = formatDate(date);
        if (dateStr != dateFormatted) {
            throw new Error("Invalid date: " + dateStr);
        }
        return date;
    }

    var formatDate = function (date) {
        var day = date.getDate();
        var monthName = date.toString().split(' ')[1];
        var year = date.getFullYear();
        return day + '-' + monthName + '-' + year;
    }

    var output = "";
    TravellingManager.init();

    commands.forEach(function(cmd) {
        var result;
        if (cmd != "") {
            try {
                result = TravellingManager.executeCommands(cmd) + "\n";
            } catch (e) {
                console.log(e);
                result = "Invalid command." + "\n";
            }
            output += result;
        }
    });

    return output;
}

// ------------------------------------------------------------
// Read the input from the console as array and process it
// Remove all below code before submitting to the judge system!
// ------------------------------------------------------------

(function() {
    var arr = [];
    if (typeof (require) == 'function') {
        // We are in node.js --> read the console input and process it
        require('readline').createInterface({
            input: process.stdin,
            output: process.stdout
        }).on('line', function(line) {
            arr.push(line);
        }).on('close', function() {
            console.log(processTravelAgencyCommands(arr));
        });
    }
})();