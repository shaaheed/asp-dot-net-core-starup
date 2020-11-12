import { NgModule } from '@angular/core';

import { CommonModule } from '@angular/common';
import { ListComponent } from './list.component';
import { TableModule } from 'src/app/shared/table/table.module';
import { TranslateModule } from '@ngx-translate/core';
import { NzToolTipModule } from 'ng-zorro-antd/tooltip';
import { NzFormModule } from 'ng-zorro-antd/form';
import { ListRoutingModule } from './list-routing.module';

@NgModule({
  declarations: [
    ListComponent
  ],
  imports: [
    ListRoutingModule,
    CommonModule,
    TableModule,
    TranslateModule,
    NzToolTipModule,
    NzFormModule
  ],
  exports: [ListComponent]
})
export class ListModule { }
