import { Component, OnInit, Input } from '@angular/core';
import { OldPremium } from 'src/app/models/old-premium';

@Component({
  selector: 'app-history',
  templateUrl: './history.component.html',
  styleUrls: ['./history.component.scss']
})
export class HistoryComponent implements OnInit {

  @Input()
  oldPremiums: OldPremium[] = [];

  constructor() { }

  ngOnInit() {
  }

}
