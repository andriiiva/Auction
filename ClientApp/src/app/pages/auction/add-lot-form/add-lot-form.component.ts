import { Component, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-add-lot-form',
  templateUrl: './add-lot-form.component.html',
  styleUrls: ['./add-lot-form.component.scss']
})
export class AddLotFormComponent {
  showForm = false;
  name: string;
  startPrice: number;
  description: string;
  userId: number;

  @Output() addLot = new EventEmitter();

  constructor() { }

  onSubmit(event) {
    this.addLot.emit(event);
    this.name = '';
    this.startPrice = null;
    this.description = '';
    this.userId = null;
    this.toggleDisplayForm();
  }

  toggleDisplayForm() {
    this.showForm = !this.showForm;
  }

}
