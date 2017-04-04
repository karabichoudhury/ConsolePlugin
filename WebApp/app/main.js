(function () {
    'use strict';

    angular
        .module('app')
        .controller('Main', main);
        

    function main($scope, $http,$rootScope) {

        $scope.buffer = [];
        $scope.show = false;
        $scope.commandSet = [];
        $rootScope.restApiBaseUrl = 'http://localhost:62243/ProductService.svc';

        $scope.keyup = function (event) {

            //if ctrl is pressed
            if ((event.keyCode===17)) {
               // console.log("keys are pressed");
                $scope.show = true;
                document.getElementById("txtInput").focus();
                //setFocus("txtInput");
                $scope.buffer = [];
            }
            //if enter is pressed
            if (event.keyCode == 13) {
                if ($scope.command != undefined) {
                    $scope.commandSet = $scope.command.split(' ');
                    console.log("execute command", $scope.command, $scope.commandSet.length);
                    $scope.buffer = [];
                    $scope.executeCommand();
                }
            }
        };

        $scope.executeCommand = function () {
            console.log("I am in function");
            $scope.commandSet = $scope.command.split(' ');
            var commandSet = $scope.commandSet;
            if (commandSet.length == 1) {
                var input = commandSet[0].toUpperCase().trim();
                switch (input) {
                    case "CLS":
                        console.log("clear is pressed");
                        document.getElementById('divOutput').innerHTML = "";
                        document.getElementById('txtInput').value = "";
                        break;
                    case "EXIT":
                        console.log("exit is typed");
                        $scope.show = false;
                        break;
                    default:
                        console.log("go to server");
                        $scope.takeAction();


                }

            }
            else
                $scope.takeAction();
        }

        $scope.takeAction = function () {


            $http.get('http://localhost:62243/ProductService.svc/GetCommand/' + $scope.command).then(function (response) {
                $scope.responseData = response.data;
                console.log(response.data);
                var newSpan =  document.createElement('span');
                newSpan.innerText = $scope.responseData[0].description;//document.getElementById('txtInput').value;
                document.getElementById('divOutput').appendChild(newSpan);
                var linebreak = document.createElement("br");
                document.getElementById('divOutput').appendChild(linebreak);
                document.getElementById('txtInput').value = "";
            });
            
            
           
        }

        //$http.get('http://localhost:62243/ProductService.svc/GetProductList').then(function (response) {
        //    $scope.products = response.data;
        //});

        //$http.get('http://localhost:62243/ProductService.svc/GetEntitiesList').then(function (response) {
        //    $scope.entities = response.data;
        //    console.log(response.data);

        //});


        //$http.get('http://localhost:62243/ProductService.svc/GetEntitiesById/1').then(function (response) {
        //    $scope.fileteredEntity = response.data;
        //});


    
        
    }
})();