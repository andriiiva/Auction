import { Component, OnInit, OnChanges } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Bid } from 'src/app/shared/bid.model';
import { AuctionService } from 'src/app/auction.service';

@Component({
  selector: 'app-lot',
  templateUrl: './lot.component.html',
  styleUrls: ['./lot.component.scss']
})
export class LotComponent implements OnInit {

  lot: any;

  public id: number;
  constructor(private route: ActivatedRoute, private AucSer: AuctionService) { }

  ngOnInit() {
    this.id = +this.route.snapshot.paramMap.get('id');
    this.AucSer.getLot(this.id).subscribe(data => {this.lot = data; this.lot.bids.reverse()});
  }

  placeBet(event) {
    this.AucSer.addBid({price: event.value.price, 
                        userId: event.value.userId, 
                        lotId: this.id} as Bid).subscribe(a => {this.lot.bids.unshift(a)});
    }

}
