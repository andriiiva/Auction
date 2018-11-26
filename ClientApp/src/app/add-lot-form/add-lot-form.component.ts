import { Component } from '@angular/core';
import { Lot } from '../auction/lot';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-add-lot-form',
  templateUrl: './add-lot-form.component.html',
  styleUrls: ['./add-lot-form.component.scss']
})
export class AddLotFormComponent {
  
  lots = [];

  constructor() { }

  onSubmit(f: NgForm) {
    this.lots.push(new Lot(f.value.name, f.value.price));
  }

  get diagnostic() { return JSON.stringify(this.lots); }
}