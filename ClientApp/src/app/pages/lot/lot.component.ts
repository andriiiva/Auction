import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Lot } from 'src/app/shared/lot.model';
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
    this.AucSer.getLot(this.id).subscribe(data => this.lot = data);
  }

}
