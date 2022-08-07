import { ChangeDetectionStrategy, Component, Input, OnInit } from '@angular/core';
import { RouteData, SideNavItem } from '@shared/models/navigation.model';

@Component({
    selector: 'side-nav-item',

    templateUrl: './side-nav-item.component.html',
    styleUrls: ['side-nav-item.component.scss'],
})
export class SideNavItemComponent implements OnInit {
    @Input() sideNavItem!: SideNavItem;
    @Input() isActive!: boolean;

    expanded = false;
    routeData!: RouteData;

    constructor() {}
    ngOnInit() {}
}
