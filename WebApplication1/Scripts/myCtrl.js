angular.module("myApp")
.controller("myCtrl", function ($scope, $http) {
    $http.get("/api/values/")
        .then(function (response) {
        $scope.myWelcome = response.data;
        });