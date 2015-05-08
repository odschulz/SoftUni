Object.prototype.extend = function(properties) {
    function f() {}
    f.prototype = Object.create(this);
    for (var prop in properties) {
        f.prototype[prop] = properties[prop];
    }

    f.prototype._super = this;
    return new f();
};

var ShapesModule = (function name() {

    var Point = {
        init: function (x, y) {
            this._x = x;
            this._y = y;

            return this;
        },
        toString: function () {
            return '(' + this._x + ', ' + this._y + ')';
        }
    };

    var Shape = {
        init: function (x, y, color) {
            this._point1 = Object.create(Point).init(x, y);
            this._color = color;

            return this;
        },
        toString: function () {
            return 'Color: ' + this._color;
        }
    };

    var Circle = Shape.extend({
        init: function (x, y, radius, color) {
            this._super.init.call(this, x, y, color);
            this._radius = radius;

            return this;
        },
        toString: function () {
            return 'Type: Circle; Coordinates: O' + this._point1
                + '; ' + this._super.toString.call(this) + ';';
        }
    });

    var Rectangle = Shape.extend({
        init: function (x, y, width, height, color) {
            this._super.init.call(this, x, y, color);
            this._width = width;
            this._height = height;

            return this;
        },
        toString: function () {
            return 'Type: Rectangle;'
                + ' Coordinates: A' + this._point1
                + '; Width: ' + this._width
                + '; Height: ' + this._height + '; '
                + this._super.toString.call(this) + ';';
        }
    });

    var Triangle = Shape.extend({
        init: function (x1, y1, x2, y2, x3, y3, color) {
            this._super.init.call(this, x1, y1, color);
            this._point2 = Object.create(Point).init(x2, y2);
            this._point3 = Object.create(Point).init(x3, y3);

            return this;
        },
        toString: function () {
            return 'Type: Triangle;'
                + ' Coordinates: A' + this._point1
                + ', B' + this._point2
                + ', C' + this._point3 + '; '
                + this._super.toString.call(this) + ';';
        }
    });

    var Line = Shape.extend({
        init: function (x1, y1, x2, y2, color) {
            this._super.init.call(this, x1, y1, color);
            this._point2 = Object.create(Point).init(x2, y2);

            return this;
        },
        toString: function () {
            return 'Type: Line;'
                + ' Coordinates: A' + this._point1
                + ', B' + this._point2 + '; '
                + this._super.toString.call(this) + ';';
        }
    });

    var Segment = Shape.extend({
        init: function (x1, y1, x2, y2, color) {
            this._super.init.call(this, x1, y1, color);
            this._point2 = Object.create(Point).init(x2, y2);

            return this;
        },
        toString: function () {
            return 'Type: Segment;'
                + ' Coordinates: A' + this._point1
                + ', B' + this._point2 + '; '
                + this._super.toString.call(this) + ';';
        }
    });

    return {
        Circle: Circle,
        Rectangle: Rectangle,
        Triangle: Triangle,
        Line: Line,
        Segment: Segment
    };
}());

var circle = Object.create(ShapesModule.Circle).init(1, 2, 5, 'FFF');
console.log(circle.toString());

var rectangle = Object.create(ShapesModule.Rectangle).init(0, 0, 2, 4, 'FFF');
console.log(rectangle.toString());

var triangle = Object.create(ShapesModule.Triangle).init(1, 1, 2, 2, 3, 3, 'FFF');
console.log(triangle.toString());

var line = Object.create(ShapesModule.Line).init(1, 1, 2, 2, 'FFF');
console.log(line.toString());

var segment = Object.create(ShapesModule.Segment).init(1, 1, 2, 2, 'FFF');
console.log(segment.toString());
