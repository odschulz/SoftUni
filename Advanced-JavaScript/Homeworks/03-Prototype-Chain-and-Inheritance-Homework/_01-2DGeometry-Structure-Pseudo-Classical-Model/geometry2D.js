Function.prototype.inherits = function (parent) {
    if (!Object.create) {
        Object.prototype.create = function (proto) {
            function F() {}
            F.prototype = proto;
            return new F;
        }
    }

    this.prototype = Object.create(parent.prototype);
    this.prototype.constructor = this;
};

/* No time to include validations */

var ShapesModule = (function () {

    var Point = (function () {
        function Point(x, y) {
            this._x = x;
            this._y = y;
        }

        Point.prototype.toString = function () {
            return '( ' + this._x + ', ' + this._y + ' )';
        };

        return Point;
    })();
    
    var Shape = (function () {
        function Shape(x, y, color) {
            this._point1 = new Point(x, y);
            this._color = color;
        }

        Shape.prototype.toString = function () {
            return 'Type: ' + this.constructor.name
                + '; Color: ' + this._color;
        };

        Object.defineProperty(Shape.prototype, "Color", {
            get: function () {
                return this._color;
            }
        });

        return Shape;
    })();

    var Circle = (function () {
        function Circle(x, y, radius, color) {
            Shape.call(this, x, y, color);

            this._radius = radius;
        }

        Circle.inherits(Shape);

        Object.defineProperties(Circle.prototype, {
            O: {
                get: function () {
                    return this._point1.toString();
                }
            },
            Radius: {
                get: function () {
                    return this._radius;
                }
            }
        });

        Circle.prototype.toString = function () {
            return Shape.prototype.toString.call(this)
            + '; Coordinates: O' + this.O + ';';
        };

        return Circle;
    })();

    var Rectangle = (function () {
        function Rectangle(x, y, width, height, color) {
            Shape.call(this, x, y, color);

            this._width = width;
            this._height = height;
        }

        Rectangle.inherits(Shape);

        Object.defineProperties(Rectangle.prototype, {
            A: {
                get: function () {
                    return this._point1.toString();
                }
            },
            Width: {
                get: function () {
                    return this._width;
                }
            },
            Height: {
                get: function () {
                    return this._height;
                }
            }
        });

        Rectangle.prototype.toString = function () {
            return Shape.prototype.toString.call(this)
                + '; Coordinates: A' + this.A
                + '; Width: ' + this.Width
                + '; Height: ' + this.Height + ';';
        };

        return Rectangle;
    })();

    var Triangle = (function () {
        function Triangle(x1, y1, x2, y2, x3, y3, color) {
            Shape.call(this, x1, y1, color);

            this._point2 = new Point(x2, y2);
            this._point3 = new Point(x3, y3);
        }

        Triangle.inherits(Shape);

        Object.defineProperties(Triangle.prototype, {
            A: {
                get: function () {
                    return this._point1.toString();
                }
            },
            B: {
                get: function () {
                    return this._point2.toString();
                }
            },
            C: {
                get: function () {
                    return this._point3.toString();
                }
            }
        });

        Triangle.prototype.toString = function () {
            return Shape.prototype.toString.call(this)
                + '; Coordinates: A' + this.A
                + ', B' + this.B
                + ', C' + this.C + ';';
        };

        return Triangle;
    })();

    var Line = (function () {
        function Line(x1, y1, x2, y2, color) {
            Shape.call(this, x1, y1, color);

            this._point2 = new Point(x2, y2);
        }

        Line.inherits(Shape);

        Object.defineProperties(Line.prototype, {
            A: {
                get: function () {
                    return this._point1.toString();
                }
            },
            B: {
                get: function () {
                    return this._point2.toString();
                }
            }
        });

        Line.prototype.toString = function () {
            return Shape.prototype.toString.call(this)
                + '; Coordinates: A' + this.A
                + ', B' + this.B + ';';
        };

        return Line;
    })();

    var Segment = (function () {
        function Segment(x1, y1, x2, y2, color) {
            Line.apply(this, arguments);
        }

        Segment.inherits(Line);

        return Segment;
    })();

    return {
        Circle: Circle,
        Rectangle: Rectangle,
        Triangle: Triangle,
        Line: Line,
        Segment: Segment
    }
    
})();

var circle = new ShapesModule.Circle(1, 2, 5, 'FFF');
console.log(circle.toString());

var rect = new ShapesModule.Rectangle(0, 0, 2, 4, 'FFF');
console.log(rect.toString());

var tri = new ShapesModule.Triangle(1, 1, 2, 2, 3, 3, 'FFF');
console.log(tri.toString());

var line = new ShapesModule.Line(1, 1, 2, 2, 'FFF');
console.log(line.toString());


var segment = new ShapesModule.Segment(1, 1, 2, 2, 'FFF');

console.log(segment.toString());



