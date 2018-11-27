import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-lot-list',
  templateUrl: './lot-list.component.html',
  styleUrls: ['./lot-list.component.scss']
})
export class LotListComponent {

  @Input() lots;

  constructor() { }


}
