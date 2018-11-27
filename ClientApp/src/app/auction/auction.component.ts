import { Component } from '@angular/core';
import { Lot } from '../shared/lot';

@Component({
  selector: 'app-auction',
  templateUrl: './auction.component.html',
  styleUrls: ['./auction.component.scss']
})

export class AuctionComponent {

  lots: Lot[] = [];

  constructor() { }

  addLotToList(lot: Lot) {
    this.lots.push(lot);
  }

}
