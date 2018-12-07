import { Component, OnInit } from '@angular/core';
import { Lot } from '../../shared/lot.model';
import { AuctionService } from '../../auction.service';

@Component({
  selector: 'app-auction',
  templateUrl: './auction.component.html',
  styleUrls: ['./auction.component.scss']
})

export class AuctionComponent implements OnInit{

  lots: Lot[] = [];

  constructor(private AucSer: AuctionService) { }

  ngOnInit() {
    this.AucSer.getLots().subscribe(data => {this.lots = data; this.lots.reverse()});
  }

  addLotToList(event) {
    this.AucSer.addLot({name: event.value.name, 
                        startPrice: event.value.startPrice, 
                        description: event.value.description,
                        userId: event.value.userId} as Lot).subscribe(a => {this.lots.unshift(a as Lot); this.lots = this.lots.slice()});
  } 

}
