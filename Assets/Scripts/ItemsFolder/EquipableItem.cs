using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipableItem : BaseItem
{
    public override void ItemUse()
    {
        throw new System.NotImplementedException();
    }

    /*
     * Esta clase tiene que mantener los stats incrementados siempre y cuando este equipada dentro de el inventario.
     * Osea tengo que simplemente agregar este objeto al array de Equipables del inventario.
     * Se supone que el inventario o el PC se encarga de sumar los stats de ese array a los stats del jugador.
     * Creo que entonces ese array debería estar constantemente en 0, no sé como
     */

}
