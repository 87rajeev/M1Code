(function () {
    'use strict';

    //Angular Controller Definition Reference1 and Dependency Should be Injected in Array Notation
    angular.module("m1cp.portal.forms").controller("FormController1", ["$scope", function ($scope) {
        alert("i am in...")
    }]);

    //Angular Controller Definition Reference2 and Dependency Should be Injected Using $inject
    angular.module("m1cp.portal.forms").controller("FormControllers", FormControllers);
    FormControllers.$inject = ['$scope'];
    function FormControllers($scope) {
        var vm = this;
        //vm.footerlinks = formService.getFooters();
        vm.getfooters = getfooters;
        vm.setfooters = setfooters;
        alert("fffff")
        function getfooters() {
            alert("getfooters")
        }

        function setfooters() {

        }
        vm.getfooters();
    }
})();
