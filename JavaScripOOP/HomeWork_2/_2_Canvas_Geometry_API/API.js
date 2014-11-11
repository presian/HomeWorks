var shapeArr = [];

function changeMenuForCurrentShape() {
    var shapePicker = document.getElementById('shapePicker');
    var selectedOption = shapePicker.options[shapePicker.selectedIndex].value;
    switch (selectedOption) {
        case 'Circle':
            document.getElementById('thirdRow').style.display = 'block';
            document.getElementById('coords2').style.display = 'none';
            document.getElementById('coords3').style.display = 'none';
            document.getElementById('rectangle').style.display = 'none';
            document.getElementById('circle').style.display = 'block';
            break;
        case 'Rectangle':
            document.getElementById('thirdRow').style.display = 'block';
            document.getElementById('coords2').style.display = 'none';
            document.getElementById('coords3').style.display = 'none';
            document.getElementById('circle').style.display = 'none';
            document.getElementById('rectangle').style.display = 'block';
            break;
        case 'Segment':
            document.getElementById('thirdRow').style.display = 'block';
            document.getElementById('coords3').style.display = 'none';
            document.getElementById('circle').style.display = 'none';
            document.getElementById('rectangle').style.display = 'none';
            document.getElementById('coords2').style.display = 'block';
            break;
        case 'Triangle':
            document.getElementById('thirdRow').style.display = 'block';
            document.getElementById('circle').style.display = 'none';
            document.getElementById('rectangle').style.display = 'none';
            document.getElementById('coords2').style.display = 'block';
            document.getElementById('coords3').style.display = 'block';
            break;
        default:
            document.getElementById('thirdRow').style.display = 'none';
            break;
    }
};

function getPoint() {
    var x = Number(document.getElementById('coordsX').value);
    var y = Number(document.getElementById('coordsY').value);
    var color = document.getElementById('colorPicker').value;
    return new Point(x, y, color);
};

function getCircle() {
    var x = Number(document.getElementById('coordsX').value);
    var y = Number(document.getElementById('coordsY').value);
    var color = document.getElementById('colorPicker').value;
    var radius = Number(document.getElementById('radius').value);
    return new Circle(x, y, color, radius);
};

function getRectangle() {
    var x = Number(document.getElementById('coordsX').value);
    var y = Number(document.getElementById('coordsY').value);
    var color = document.getElementById('colorPicker').value;
    var width = Number(document.getElementById('rectWidth').value);
    var height = Number(document.getElementById('rectHeight').value);
    return new Rectangle(x, y, color, width, height);
};

function getSegment() {
    var x = Number(document.getElementById('coordsX').value);
    var y = Number(document.getElementById('coordsY').value);
    var color = document.getElementById('colorPicker').value;
    var x2 = Number(document.getElementById('coordsX2').value);
    var y2 = Number(document.getElementById('coordsY2').value);
    return new Segment(x, y, color, x2, y2);
};

function getTriangle() {
    var x = Number(document.getElementById('coordsX').value);
    var y = Number(document.getElementById('coordsY').value);
    var color = document.getElementById('colorPicker').value;
    var x2 = Number(document.getElementById('coordsX2').value);
    var y2 = Number(document.getElementById('coordsY2').value);
    var x3 = Number(document.getElementById('coordsX3').value);
    var y3 = Number(document.getElementById('coordsY3').value);
    return new Triangle(x, y, color, x2, y2, x3, y3);
};

function addShape() {
    var selectedOption = document.getElementById('shapePicker').value;
    var shapeListInSelectMode = document.getElementById('shapeListSelect');
    var childOption = document.createElement('option');
    var shapeAsText;
    switch (selectedOption) {
        case 'Circle':
            var circle = getCircle();
            shapeArr.push(circle);
            shapeAsText = 'Circle - ' + circle.toString();
            break;
        case 'Rectangle':
            var rectangle = getRectangle();
            shapeArr.push(rectangle);
            shapeAsText = 'Rectangle - ' + rectangle.toString();
            break;
        case 'Segment':
            var segment = getSegment();
            shapeArr.push(segment);
            shapeAsText = 'Segment - ' + segment.toString();
            break;
        case 'Triangle':
            var triangle = getTriangle();
            shapeArr.push(triangle);
            shapeAsText = 'Triangle - ' + triangle.toString();
            break;
        case 'Point':
            var point = getPoint();
            shapeArr.push(point);
            shapeAsText = 'Point - ' + point.toString();
            break;
    }
    childOption.innerHTML = shapeAsText;
    shapeListSelect.appendChild(childOption);
    updateCanvas();
};

function removeShape() {
    var list = document.getElementById('shapeListSelect')
    var selectIndex = list.selectedIndex;
    var selected = list.options[list.selectedIndex];
    shapeArr.splice(selectIndex, 1);
    list.removeChild(selected);
    updateCanvas();
};

function shapeDown() {
    var shapeList = document.getElementById('shapeListSelect');
    var shapeBeforeSelected = shapeList.selectedIndex;
    var selectedShape = shapeList.options[shapeList.selectedIndex];
    if (shapeBeforeSelected == 0) {
        return;
    };
    shapeList.insertBefore(selectedShape, shapeList.childNodes[shapeBeforeSelected]);
    updateShapeArray(shapeBeforeSelected, 'down');
    shapeArr.forEach(console.log.bind(console));
    updateCanvas();
};

function shapeUp() {
    var shapeList = document.getElementById('shapeListSelect');
    var selectedShape = shapeList.options[shapeList.selectedIndex];
    var shapeBeforeSelected = shapeList.selectedIndex;
    var upperShape = shapeList.options[shapeList.selectedIndex + 1];
    if (upperShape === undefined) {
        return;
    };
    upperShape.parentNode.insertBefore(selectedShape, upperShape.nextSibling);
    updateShapeArray(shapeBeforeSelected, 'up');
    shapeArr.forEach(console.log.bind(console));
    updateCanvas();
};

function updateCanvas() {
    var canvas = document.getElementById('result');
    var context = canvas.getContext('2d');
    context.clearRect(0, 0, canvas.width, canvas.height);
    for (var i = 0; i < shapeArr.length; i++) {
        shapeArr[i].draw();
    };
}

function updateShapeArray(index, type) {
    switch (type) {
        case 'up':
            var temp = shapeArr[index];
            var temp1 = shapeArr[index + 1];
            shapeArr.splice(index, 2, temp1, temp);
            break;
        case 'down':
            var temp = shapeArr[index];
            var temp1 = shapeArr[index - 1];
            shapeArr.splice(index - 1, 2, temp, temp1);
            break;
    }
};

document.getElementById('shapePicker').addEventListener('change', changeMenuForCurrentShape);
document.getElementById('addButton').addEventListener('click', addShape);
document.getElementById('remove').addEventListener('click', removeShape);
document.getElementById('up').addEventListener('click', shapeUp);
document.getElementById('down').addEventListener('click', shapeDown);