//
// This is only a SKELETON file for the 'Bank Account' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export class BankAccount {
  constructor() {
    this.isActive = false
    this._balance
  }

  open() {
    if (this.isActive) throw new ValueError()
    this.isActive = true
    this._balance = 0
  }

  close() {
    if (this.isActive) this.isActive = false
    else throw new ValueError()
  }

  deposit(value) {
    if (value < 0 || !this.isActive) throw new ValueError()
    this._balance += value;
  }

  withdraw(value) {
    if (value < 0 || value > this._balance || !this.isActive) throw new ValueError()
    this._balance -= value
  }

  get balance() {
    if (!this.isActive) throw new ValueError()
    return this._balance     
  }
}

export class ValueError extends Error {
  constructor() {
    super('Bank account error');
  }
}
