var m1app = angular.module("m1app", ["ngSanitize", "ui.bootstrap"]);

angular.element(document).ready(function () {
    $('.lazyload').Lazy({
        threshold: 0,
        chainable: false,
        effect: "fadeIn",
        effectTime: 1000,
        beforeLoad: function (element) {
        },
        afterLoad: function (element) {
            var picturetag = element[0];
            if (picturetag.nodeName == 'PICTURE') {
                var imageTag = angular.element(element[0].lastElementChild);
                imageTag.removeClass('imagewidthloader');
            }
            else {
                element.removeClass('imagewidthloader');
            }
            var parentdiv = element[0].offsetParent;
            var childElemnt = angular.element(parentdiv.nextElementSibling);
            childElemnt.removeClass('hide-content-beforeload');
            bannerTextAnimation();
        },
    });


    function bannerTextAnimation() {
        /*Start of animation for A4 sliding top to bottom*/
        var $animation_elements = $('.animation-element');
        var $window = $(window);

        function view_port() {
            var window_height = $window.height();
            var window_top_position = $window.scrollTop();
            var window_bottom_position = (window_top_position + window_height);

            $.each($animation_elements, function () {
                var $element = $(this);
                var element_height = $element.outerHeight();
                var element_top_position = $element.offset().top;
                var element_bottom_position = (element_top_position + element_height);

                //check to see if this current container is within viewport
                if ((element_bottom_position >= window_top_position)) {
                    if (!$element.hasClass("in-view"))
                        $element.addClass('in-view');
                }

            });
        }

        $window.on('scroll resize', view_port);
        $window.trigger('scroll');
        /*End of animation for A4 sliding top to bottom*/
    }


});


m1app.filter('html', ['$sce', function ($sce) {
    return function (text) {
        return $sce.trustAsHtml(text);
    };
}]);

m1app.controller('headerController', function ($scope, $timeout, $window) {
    angular.element($window).bind("scroll", function () {
        if ($(window).scrollTop() > 50) {
            $(".navbar-default").addClass("active");
        } else {
            //remove the background property so it comes transparent again (defined in your css)
            $(".navbar-default").removeClass("active");
        }

    });
});


//scroll to top animation using angularJS. Pass value in milliseconds in html to set time taken (timeTaken) to scroll to top of page
m1app.controller('footerController', function ($scope, $timeout, $window) {
    $scope.scrollToTop = function (timeTaken) {
        $('html').animate({
            scrollTop: 0
        }, timeTaken);
    };

});

// slide to section-animation for moving to next section
m1app.controller('arrowClickController', function ($scope, $timeout, $window) {
    $scope.scrollToSection = function (b) {
        $('html').animate({
            scrollTop: $("#" + b).offset().top
        }, 800);
    };
    $scope.scroll = function (classname) {
        var body = angular.element(document).find('body,html');
        body.animate({
            scrollTop: $("." + classname).offset().top
        }, 800);
    };

});

// slide to section-animation for moving to next section
m1app.controller('commonController', function ($scope, $timeout, $window) {
});
m1app.directive("backgroundImg", function ($timeout) {

    return {
        restrict: 'A',
        link: function (scope, elem, attrs) {
            elem.css({
                'background': 'url(' + attrs.backgroundImg + ') no-repeat',
                'background-size': 'cover'
            });
        }
    }

});

m1app.directive("carouselComponent", function ($timeout) {
    return {

        restrict: "A",

        scope: {


        }, controller: function ($element) {

        },
        link: function (scope, element, attrs) {
            var minItem = parseInt(attrs.minitem);
            var maxItem = parseInt(attrs.maxitem);
            var speed = parseInt(attrs.speed);
            var autoplay = JSON.parse(attrs.autoplay);
            var infinite = JSON.parse(attrs.infinite);
            var dots = JSON.parse(attrs.dots);
            var autoplaySpeed = parseInt(attrs.autoplayspeed);
            var slidesToScroll = parseInt(attrs.slidestoscroll);
            var queryResult = element[0].querySelector('.slider');
            var wrappedQueryResult = angular.element(queryResult);



            angular.element(document).ready(function () {
                element.slick({
                    lazyLoad: 'ondemand',
                    speed: speed,
                    autoplay: autoplay,
                    infinite: infinite,
                    autoplaySpeed: autoplaySpeed,
                    centerMode: false,
                    slidesToShow: maxItem,
                    slidesToScroll: slidesToScroll,
                    arrows: true,
                    dots: dots,
                    draggable: false,
                    focusOnSelect: false,
                    pauseOnFocus: false,
                    pauseOnHover: false,
                    mobilefirst: true,
                    prevArrow: "<img class='a-left control-c prev slick-prev' src='/images/Carousel-ArrowLeft-icon-1x.png'>",
                    nextArrow: "<img class='a-right control-c next slick-next' src='/images/Carousel-ArrowRight-icon-1x.png'>",

                    responsive: [
                     {
                         breakpoint: 1204,
                         settings: {
                             autoplay: false,
                             infinite: true,
                             arrows: false,
                             dots: false,
                             centerMode: true,
                             slidesToScroll: slidesToScroll,
                             slidesToShow: maxItem > 3 ? 3 : maxItem,
                             centerPadding: minItem > 1 ? '20px' : '40px',
                         }
                     },
                     {
                         breakpoint: 768,
                         settings: {
                             autoplay: false,
                             infinite: true,
                             arrows: false,
                             dots: false,
                             centerMode: true,
                             slidesToScroll: 1,
                             centerPadding: minItem > 1 ? '20px' : '40px',
                             slidesToShow: minItem > 1 ? 2 : 1,
                             initialSlide: minItem > 1 ? 1 : 0,
                         }
                     }
                    ]

                });
                iconpossition();
            });
            function iconpossition() {
                //sllick arrow icon possition
                var dottedImage = element[0].querySelector('.arrow-position ');
                var wrappeddottedImage = angular.element(dottedImage);
                var slickNext = element[0].querySelector('.slick-next');
                var wrappedslickNext = angular.element(slickNext);
                var slickPrevious = element[0].querySelector('.slick-prev');
                var wrappedslickPrevious = angular.element(slickPrevious);
                var height = wrappeddottedImage.height() / 2;
                var flag = wrappeddottedImage.hasClass("Carousel-deviceDetailsImage");
                if (flag) {
                    height = height + 20;
                }

                wrappedslickNext.css({
                    'top': height
                });
                wrappedslickPrevious.css({
                    'top': height
                });
            };

            element.on('beforeChange', function (event, slick, currentSlide, nextSlide) {
                var currentSlide = currentSlide / slidesToScroll;
                var nextSlide = nextSlide / slidesToScroll;
                if (slick.$dots) {
                    slick.$dots.children().children().html('');
                    var direction = nextSlide > currentSlide ? 1 : 0;
                    var indicator_c = direction ? 'next' : 'prev';
                    $current_dot = slick.$dots.children().children().eq(currentSlide);
                    $current_dot.html('<div class="dot-indicator ' + indicator_c + '">');
                    setTimeout(function () {
                        $current_dot.html('');
                    }, 200);
                }

            });
        },
        controllerAs: 'ctrl'
    }
});
m1app.directive("viewAll", function ($timeout) {
    return {
        restrict: 'A',
        link: function (scope, element, attrs, $window) {
            element.bind("click", function () {
                var cuurentdom = angular.element(element);
                var current = cuurentdom.hasClass('view-all');
                if (current) {
                    cuurentdom.siblings('.div-static').addClass("hide-device-promortion");
                    cuurentdom.siblings('.div-dymanic').removeClass("hide-device-promortion");
                    cuurentdom.siblings('.view-less').removeClass("hide-device-promortion");
                    cuurentdom.addClass("hide-device-promortion");
                } else {
                    cuurentdom.siblings('.div-static').removeClass("hide-device-promortion");
                    cuurentdom.siblings('.div-dymanic').addClass("hide-device-promortion");
                    cuurentdom.siblings('.view-all').removeClass("hide-device-promortion");
                    cuurentdom.addClass("hide-device-promortion");

                }
            });
        }
    }
});
m1app.directive("megamenuArrow", function ($timeout) {

    return {
        restrict: 'A',
        link: function (scope, elem, attrs) {
            elem.bind('click', function (e) {
                if (elem.parent().hasClass('activesubmenue')) {
                    elem.parent().removeClass('activesubmenue');
                }
                else {
                    elem.parent().addClass('activesubmenue');
                }

                elem.next('ul').toggle();
                e.stopPropagation();
                e.preventDefault();
            });
        }
    }
});

m1app.directive("deviceviewAll", function ($timeout) {
    return {
        restrict: 'A',
        link: function (scope, element, attrs, $window) {
            element.bind("click", function () {
                var cuurentdom = angular.element(element);
                var current = cuurentdom.hasClass('view-all');
                if (current) {
                    cuurentdom.siblings('.static-prmotion').addClass("hide-device-promortion");
                    cuurentdom.siblings('.dynamic-prmotion').removeClass("hide-device-promortion");
                    cuurentdom.siblings('.view-less').removeClass("hide-device-promortion");
                    cuurentdom.addClass("hide-device-promortion");
                } else {
                    cuurentdom.siblings('.static-prmotion').removeClass("hide-device-promortion");
                    cuurentdom.siblings('.dynamic-prmotion').addClass("hide-device-promortion");
                    cuurentdom.siblings('.view-all').removeClass("hide-device-promortion");
                    cuurentdom.addClass("hide-device-promortion");

                }
            });
        }
    }
});
m1app.directive("equalHeight", function ($timeout) {
    return {
        restrict: 'A',
        link: function (scope, element, attrs, $window) {

            angular.element(document).ready(function () {
                length = element.find(".equal-component").length;
                maxheight = 1;
                for (var i = 0; i < length; i++) {
                    var dom = element.find(".equal-component")[i];
                    var height = angular.element(dom).innerHeight();

                    if (maxheight <= height) {
                        maxheight = height;
                    }

                }
                element.find(".equal-component").css("min-height", maxheight + "px");
            });
        }
    }
});