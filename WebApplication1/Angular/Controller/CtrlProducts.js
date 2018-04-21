angular.module("myApp", [])
    .controller("CtrlProducts", function ($scope, $http) {
    $http.get("/api/values/" + id)
        .then(function (response) {
            $scope.myWelcome = response.data;
        });
});