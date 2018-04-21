angular.module("myApp")
    .controller("CtrlStores", function ($scope, $http) {
        $http.get("/api/values/")
            .then(function (response) {
                $scope.myWelcome = response.data;
            });
    });