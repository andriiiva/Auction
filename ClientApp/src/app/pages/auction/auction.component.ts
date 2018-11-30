import { Component, OnInit, OnChanges } from '@angular/core';
import { Lot } from '../../shared/lot.model';
import { AuctionService } from '../../auction.service';

@Component({
  selector: 'app-auction',
  templateUrl: './auction.component.html',
  styleUrls: ['./auction.component.scss']
})

export class AuctionComponent implements OnInit, OnChanges {

  lots: Lot[] = [];

  constructor(private AucSer: AuctionService) { }

  ngOnInit() {
    this.AucSer.getLots().subscribe(data => this.lots = data);
  }

  ngOnChanges() {
    this.AucSer.getLots().subscribe(data => this.lots = data);
  }

  addLotToList(event) {
    this.AucSer.addLot({name: event.value.name, startPrice: event.value.startPrice} as Lot).subscribe(a => this.lots.push(a));
  } 
}
