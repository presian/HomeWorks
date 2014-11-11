Object.prototype.inherits = function(parent) {
    this.prototype = Object.create(parent.prototype);
    this.prototype.constructor = this;
}
var Shape = (function() {
    function Shape(x, y, color) {
        this._x = x;
        this._y = y;
        this._color = color;
    }
    Shape.prototype = {
        toString: function() {
            return "x = " + this._x + "\ny = " + this._y + "\ncolor: " + this._color
        },
        draw: function(argument) {
            var canvas = document.getElementById('result');
            var context = canvas.getContext('2d');
            context.beginPath();
            context.fillStyle = this._color;
            return context;
        }
    }
    return Shape;
})();

var Point = (function() {
    function Point(x, y, color) {
        Shape.call(this, x, y, color);
    }
    Point.inherits(Shape);
    Point.prototype.draw = function() {
        contextPoint = Shape.prototype.draw.call(this);
        contextPoint.arc(this._x, this._y, 1, 0, 2 * Math.PI, false);
        contextPoint.fill();
        return contextPoint;
    }
    return Point;
})();

var Circle = (function() {
    function Circle(x, y, color, radius) {
        Shape.call(this, x, y, color)
        this._radius = radius;
    }
    Circle.inherits(Shape);
    Circle.prototype = {
        toString: function() {
            var output = Shape.prototype.toString.call(this);
            output = output + '\nRadius: ' + this._radius;
            return output;
        },
        draw: function() {
            var contextCircle = Shape.prototype.draw.call(this);
            contextCircle.arc(this._x, this._y, this._radius, 0, 2 * Math.PI, false);
            contextCircle.fill();
        }
    }

    return Circle;
})();

var Rectangle = (function() {
    function Rectangle(x, y, color, width, height) {
        Shape.call(this, x, y, color);
        this._width = width;
        this._height = height;
    }
    Rectangle.inherits(Shape);
    Rectangle.prototype = {
        toString: function() {
            return Shape.prototype.toString.call(this) + "\nWidth: " + this._width + "\nHeight: " + this._height;
        },
        draw: function() {
            var contextRect = Shape.prototype.draw.call(this);
            contextRect.rect(this._x, this._y, this._width, this._height);
            contextRect.fill();
            return contextRect;
        }
    }
    return Rectangle;
})();

var Segment = (function() {
    function Segment(x, y, color, x2, y2) {
        Shape.call(this, x, y, color);
        this._x2 = x2;
        this._y2 = y2;
    }
    Segment.inherits(Shape);

    Segment.prototype = {
        toString: function() {
            return Shape.prototype.toString.call(this) + "\nx2 = " + this._x2 + "\ny2 = " + this._y2;
        },
        draw: function() {
            var contextSegment = Shape.prototype.draw.call(this);
            contextSegment.moveTo(this._x, this._y);
            contextSegment.lineTo(this._x2, this._y2);
            contextSegment.strokeStyle = this._color;
            contextSegment.stroke();
            return contextSegment;
        }
    }
    return Segment;
})();

var Triangle = (function() {
    function Triangle(x, y, color, x2, y2, x3, y3) {
        Segment.call(this, x, y, color, x2, y2);
        this._x3 = x3;
        this._y3 = y3;
    }
    Triangle.inherits(Segment);
    Triangle.prototype = {
        toString: function() {
            return Segment.prototype.toString.call(this) + "\nx3 = " + this._x3 + "\ny3 = " + this._y3;
        },
        draw: function() {
            contextTriangle = Shape.prototype.draw.call(this);
            contextTriangle.moveTo(this._x, this._y);
            contextTriangle.lineTo(this._x2, this._y2);
            contextTriangle.lineTo(this._x3, this._y3);
            contextTriangle.lineTo(this._x, this._y);
            contextTriangle.lineJoin = 'miter';
            contextTriangle.closePath();
            contextTriangle.fill();
            return contextTriangle;
        }
    }
    return Triangle;
})();

// exports.Point = Point;
// exports.Circle = Circle;
// exports.Rectangle = Rectangle;
// exports.Segment = Segment;
// exports.Triangle = Triangle;


// console.log(new Point(1, 2, "white").toString());
// console.log(new Circle(1, 6, "black", 8).toString());
// console.log(new Rectangle(5, 5, "red", 2.2, 8.6).toString());
// console.log(new Segment(5, 5, "blue", 4, 7).toString());
// console.log(new Triangle(1, 3, "blue", 5, 8, 6, 9).toString());