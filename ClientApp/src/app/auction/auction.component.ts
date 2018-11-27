import { Component, OnInit } from '@angular/core';
import { Lot } from '../shared/lot.model';
import { AuctionService } from '../auction.service';

@Component({
  selector: 'app-auction',
  templateUrl: './auction.component.html',
  styleUrls: ['./auction.component.scss']
})

export class AuctionComponent implements OnInit {

  lots: Lot[] = [];

  constructor(private AucSer: AuctionService) { }

  ngOnInit() {
    this.AucSer.getLots().subscribe(data => console.log(data));
  }

  addLotToList(event) {
    this.lots.push({name: event.value.name, price: event.value.price} as Lot);
  } 

}
