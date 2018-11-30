import { Component, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-add-lot-form',
  templateUrl: './add-lot-form.component.html',
  styleUrls: ['./add-lot-form.component.scss']
})
export class AddLotFormComponent {
  showForm = false;

  @Output() addLot = new EventEmitter();

  constructor() { }

  onSubmit(event) {
    this.addLot.emit(event);
  }

  toggleDisplayForm() {
    this.showForm = !this.showForm;
  }

}
