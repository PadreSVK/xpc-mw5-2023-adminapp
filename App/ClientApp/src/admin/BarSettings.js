import React, {useEffect, useState} from "react";
import {
    Table,
    Button,
    Modal,
    ModalHeader,
    ModalBody,
    ModalFooter,
    Input,
    FormGroup,
    Label,
    Form,
    InputGroup, InputGroupText
} from "reactstrap";

function InputGroupAddon(props) {
    return null;
}

const BarSettings = () => {
    const [isBarModalOpen, setIsBarModalOpen] = useState(false);
    const [isDrinkModalOpen, setIsDrinkModalOpen] = useState(false);

    // sample data for the tables
    const barItemsConstants = [
        {name: "Beer", unit: "0.5", unitPrice: 50, volume: "50", stock: 20},
        {name: "Wine", unit: "0.2", unitPrice: 60, volume: "5", stock: 10},
        {name: "Rum", unit: "0.04", unitPrice: 50, volume: "1", stock: 5}
    ];

    const drinks = [
        {name: "Cuba Libre", price: 90},
        {name: "Skinny bitch", price: 80},
        {name: "Long Island Iced Tea", price: 150}
    ];

    const [barItems, setBarItems] = useState([{ name: "", quantity: 1 }]);

    const [numInputGroups, setNumInputGroups] = useState(2);

    const toggleDrinkModal = () => {
        setIsDrinkModalOpen(!isDrinkModalOpen);
        setNumInputGroups(2); // Reset the number of input groups to 2 every time the modal is opened
    };

    const addBarItem = () => {
        setBarItems([...barItems, { name: "", quantity: 1 }]);
        setNumInputGroups(numInputGroups + 1);
    };

    const removeBarItem = (index) => {
        const newBarItems = [...barItems];
        newBarItems.splice(index, 1);
        setBarItems(newBarItems);
        setNumInputGroups(numInputGroups - 1);
    };

    const handleBarNameChange = (event, index) => {
        const newBarItems = [...barItems];
        newBarItems[index].name = event.target.value;
        setBarItems(newBarItems);
    };

    const handleBarQuantityChange = (event, index) => {
        const newBarItems = [...barItems];
        newBarItems[index].quantity = event.target.value;
        setBarItems(newBarItems);
    };



    const toggleBarModal = () => setIsBarModalOpen(!isBarModalOpen);

    return (
        <div>
            <button onClick={toggleBarModal}>Add</button>
            <Table>
                <thead>
                <tr>
                    <th>Bar Item</th>
                    <th>Unit</th>
                    <th>Unit Price</th>
                    <th>Volume</th>
                    <th>Stock</th>
                    <th></th>
                </tr>
                </thead>
                <tbody>
                {barItemsConstants.map(item => (
                    <tr key={item.name}>
                        <td>{item.name}</td>
                        <td>{item.unit}</td>
                        <td>{item.unitPrice}</td>
                        <td>{item.volume}</td>
                        <td>{item.stock}</td>
                        <td><button onClick={toggleBarModal}>Edit</button></td>
                    </tr>
                ))}
                </tbody>
            </Table>

            <button onClick={toggleBarModal}>Add</button>
            <Table>
                <thead>
                <tr>
                    <th>Drink Name</th>
                    <th>Price</th>
                    <th></th>
                </tr>
                </thead>
                <tbody>
                {drinks.map(drink => (
                    <tr key={drink.name}>
                        <td>{drink.name}</td>
                        <td>{drink.price}</td>
                        <td><button onClick={toggleDrinkModal}>Edit</button></td>
                    </tr>
                ))}
                </tbody>
            </Table>

            <Modal isOpen={isBarModalOpen} toggle={toggleBarModal}>
                <ModalHeader>Edit Bar Item</ModalHeader>
                <ModalBody>
                    <Form>
                        <FormGroup>
                            <Label for="barItemName">Bar Item Name</Label>
                            <Input type="text" name="barItemName" id="barItemName" value="" />
                        </FormGroup>
                        <FormGroup>
                            <Label for="barItemUnit">Unit</Label>
                            <Input type="text" name="barItemUnit" id="barItemUnit" value="" />
                        </FormGroup>
                        <FormGroup>
                            <Label for="barItemUnitPrice">Unit Price</Label>
                            <Input type="number" name="barItemUnitPrice" id="barItemUnitPrice" />
                        </FormGroup>
                        <FormGroup>
                            <Label for="barItemVolume">Volume</Label>
                            <Input type="number" name="barItemVolume" id="barItemVolume"/>
                        </FormGroup>
                        <FormGroup>
                            <Label for="barItemStock">Stock</Label>
                            <Input type="number" name="barItemStock" id="barItemStock"/>
                        </FormGroup>
                    </Form>
                </ModalBody>
                <ModalFooter>
                    <button color="primary" onClick={toggleBarModal}>Save Changes</button>{' '}
                    <button color="secondary" onClick={toggleBarModal}>Cancel</button>
                </ModalFooter>
            </Modal>


            <Modal isOpen={isDrinkModalOpen} toggle={toggleDrinkModal}>
                <ModalHeader toggle={toggleDrinkModal}>Edit Drink Item</ModalHeader>
                <ModalBody>
                    <FormGroup>
                        <Label for="drinkName">Drink Name</Label>
                        <Input
                            type="text"
                            name="drinkName"
                            id="drinkName"
                            placeholder="Enter drink name"
                        />
                    </FormGroup>
                    <FormGroup>
                        <Label for="drinkPrice">Drink Price</Label>
                        <Input
                            type="number"
                            name="drinkPrice"
                            id="drinkPrice"
                            placeholder="Enter drink price"
                            min="0"
                        />
                    </FormGroup>
                    {[...Array(numInputGroups)].map((_, index) => <FormGroup key={index}>
                        <Label>Bar Item #{index + 1}</Label>
                        <div className="d-flex justify-content-between">
                            <InputGroup>
                                <Input
                                    type="text"
                                    value={barItems[index]?.name || ""}
                                    onChange={(event) => handleBarNameChange(event, index)}
                                    placeholder="Enter bar item name"
                                />
                                <InputGroupAddon addonType="append">
                                    <InputGroupText>Quantity</InputGroupText>
                                </InputGroupAddon>
                                <Input
                                    type="number"
                                    value={barItems[index]?.quantity || ""}
                                    onChange={(event) => handleBarQuantityChange(event, index)}
                                    placeholder="Enter quantity"
                                    min="1"
                                />

                            </InputGroup>
                            <button onClick={removeBarItem}>
                                Remove
                            </button>
                        </div>
                    </FormGroup>)}
                    <button color="primary" onClick={addBarItem}>
                        Add Bar Item
                    </button>
                </ModalBody>
                <ModalFooter>
                    <button color="primary" onClick={toggleDrinkModal}>
                        Save Changes
                    </button>{" "}
                    <button color="secondary" onClick={toggleDrinkModal}>
                        Cancel
                    </button>
                </ModalFooter>
            </Modal>





        </div>
    );
}
export default BarSettings;
