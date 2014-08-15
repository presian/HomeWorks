function calcCylinderVolume(r, h) {
    var volume = Math.PI * r * r * h;
    return volume;
}
console.log(calcCylinderVolume(2, 4).toFixed(3));
console.log(calcCylinderVolume(5, 8).toFixed(3));
console.log(calcCylinderVolume(12, 3).toFixed(3));