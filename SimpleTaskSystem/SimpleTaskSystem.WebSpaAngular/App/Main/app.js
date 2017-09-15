(function () {
    'use strict';

    var app = angular.module('app', [
        'ngAnimate',
        'ngSanitize',

        'ui.router',
        'ui.bootstrap',
        'ui.jq',

        'abp'
    ]);

    //Configuration for Angular UI routing.
    app.config([
        '$stateProvider', '$urlRouterProvider',
        function ($stateProvider, $urlRouterProvider) {
            $urlRouterProvider.otherwise('/treeview');
            $stateProvider
                .state('treeview', {
                    url: '/treeview',
                    templateUrl: '/App/Main/views/treeview/treeview.cshtml',
                    menu: 'TreeView' //Matches to name of 'NewTask' menu in SimpleTaskSystemNavigationProvider
                });
        }
    ]);

})();