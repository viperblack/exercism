//
// This is only a SKELETON file for the 'Matrix' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

/* export class Matrix {
  constructor() {
    throw new Error('Remove this statement and implement this function');
  }

  get rows() {
    throw new Error('Remove this statement and implement this function');
  }

  get columns() {
    throw new Error('Remove this statement and implement this function');
  }
} */
export class Matrix {
  constructor(matrixStr) {
    this._rows = matrixStr.split(/\n/).map(l => l.split(/\s+/).map(n => +n));
    this._columns = this._rows.reduce((prev, next) => next.map((item, i) =>(prev[i] || []).concat(next[i])), []);
  }
    get rows() {
    return this._rows;
  }
  get columns() {
    return this._columns;
  }
}
