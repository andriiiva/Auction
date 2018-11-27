import { Component, Output, EventEmitter } from '@angular/core';
import { Lot } from '../shared/lot.model';

@Component({
  selector: 'app-add-lot-form',
  templateUrl: './add-lot-form.component.html',
  styleUrls: ['./add-lot-form.component.scss']
})
export class AddLotFormComponent {

  @Output() addLot = new EventEmitter();

  constructor() { }

  onSubmit(event) {
    this.addLot.emit(event);
  }

}